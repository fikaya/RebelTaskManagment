using Microsoft.EntityFrameworkCore;
using RebelsTasks.DataAccess;
using RebelsTasks.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebelsTasks.UI.FormMain
{
    public partial class GridMain : Form
    {
        public GridMain()
        {
            InitializeComponent();
        }
        private int _id;
        public GridMain(int id)
        {
            _id = id;
            InitializeComponent();
        }
        private void GridMain_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        //Sil
        private void görevListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdMain.SelectedRows.Count>0)
            {
                RebelTaskContext rebelTaskContext = new RebelTaskContext();

                var mains = (MainTask)grdMain.SelectedRows[0].DataBoundItem;

                var mainTask = rebelTaskContext.MainTask.Find(mains.Id);

                if (mainTask!=null)
                {
                    rebelTaskContext.Remove(mainTask);
                    rebelTaskContext.SaveChanges();
                    RefreshGrid();
                }
            }

        }

        private void RefreshGrid()
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            var dbQuery = rebelTaskContext.MainTask.Include(pro => pro.Project).Include(emp => emp.AssignedToEmployee).Where(main => main.ProjectId == _id).ToList();
            if (dbQuery.Count != 0)
            {
                grdMain.AutoGenerateColumns = false;
                grdMain.DataSource = null;
                grdMain.DataSource = dbQuery;
            }
            else
            {
                MessageBox.Show("Maalesef Bu Projeye Ait Görev Yok");
                Close();
            }
        }

      
        //Alt Görevleri Görecek Messager Box Kutusu
        private void altGörevListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (grdMain.SelectedRows.Count > 0)
            {
                RebelTaskContext rebelTaskContext = new RebelTaskContext();

                var mains = (MainTask)grdMain.SelectedRows[0].DataBoundItem;

                var mainTask = rebelTaskContext.MainTask.Find(mains.Id);

                if (mainTask != null)
                {
                    //Explicit Loading
                    rebelTaskContext.Entry(mainTask).Collection(mtk=>mtk.SubTasks).Load();
                }

                string input = "";
                string star = "****************";

                if (mainTask.SubTasks.Count!=0)
                {
                    foreach (var item in mainTask.SubTasks)
                    {
                      input=input+"İsmi:"+item.Name+"\n"+ "Açıklaması:" +item.Description +"\n"+ "Durumu:"+item.Status+"\n"+"Başlangıç Tarihi:"+item.StartedOn+"\n"+star+"\n";
                        
                    }
                    MessageBox.Show(input);
                }
            }
        }

        //Güncelleme
        private void grdMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            var mains = (MainTask)grdMain.SelectedRows[0].DataBoundItem;

            var mainTask = rebelTaskContext.MainTask.Find(mains.Id);

            if (mainTask != null)
            {
                UpdateMain updateMain = new UpdateMain(mainTask.Id);
                updateMain.Show();
                updateMain.FormClosed += UpdateMain_FormClosed;
            }
        }

        private void UpdateMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private void grdMain_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdMain.SelectedRows.Count>0)
            {
                grdMain.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}
