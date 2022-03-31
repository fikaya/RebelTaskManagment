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

namespace RebelsTasks.UI.DepartmantForm
{
    public partial class GridDepartment : Form
    {
        public GridDepartment()
        {
            InitializeComponent();
        }

        private void GridDepartment_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            var dbQuery = rebelTaskContext.Department.ToList();
            grdDepartment.AutoGenerateColumns = false;
            grdDepartment.DataSource = null;
            grdDepartment.DataSource = dbQuery;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var departmentId=((Department)(grdDepartment.Rows[e.RowIndex].DataBoundItem)).DepartmentId;
           
            if (grdDepartment.SelectedRows.Count>0)
            {
                var rebelTaskContext = new RebelTaskContext();
                try
                {
                    if (rebelTaskContext.Department.Find(departmentId) != null)
                    {
                        UpdateDepartmant updateDepartmant = new UpdateDepartmant(departmentId);
                        updateDepartmant.Show();
                        updateDepartmant.FormClosed += UpdateDepartmant_FormClosed;
                    }
                    else
                    {
                        MessageBox.Show("Güncellenecek Kayıt Bulunamadı.");
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Bir Hata Meydana Geldi:"+ex.Message);
                }
            }
          
        }

        private void UpdateDepartmant_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdDepartment.SelectedRows.Count > 0)//En az biri seçili ise
            {
                //e.RowIndex =>Seçili Satır
                grdDepartment.Rows[e.RowIndex].Selected = true;
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            if (grdDepartment.SelectedRows.Count > 0)
            {
                var department = (Department)grdDepartment.SelectedRows[0].DataBoundItem;
                var department01 = rebelTaskContext.Department.Find(department.DepartmentId);
                try
                {
                    if (department01 != null)
                    {
                        rebelTaskContext.Department.Remove(department01);

                        rebelTaskContext.SaveChanges();

                        RefreshGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi:" + ex.Message);
                }

            }
        }

        private void çalışanlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            string input = "";

            if (grdDepartment.SelectedRows.Count > 0)
            {
                var department = (Department)grdDepartment.SelectedRows[0].DataBoundItem;

                try
                {
                    if (rebelTaskContext.Department.Find(department.DepartmentId) != null)
                    {
                        //Eager Loading
                        //var department01 = rebelTaskContext.Department.Include(emp=>emp.Employees)
                        //    .Where(dep => dep.DepartmentId == department.DepartmentId)
                        //    .First();

                        var department01 = rebelTaskContext.Department
                            .First(dep => dep.DepartmentId == department.DepartmentId);

                        //Explicit Loading(Sonradan Açıktan Yükleme)
                        rebelTaskContext.Entry(department01).Collection(emp => emp.Employees).Load();

                        if (department01.Employees.Count != 0)
                        {
                            foreach (var item in department01.Employees)
                            {
                                input = input + item.Title + "::" + item.FullName + "\n";
                            }

                            MessageBox.Show(input);
                        }
                        else
                        {
                            MessageBox.Show("Maalesef Bu Departmanda Bir Çalışan Yok.");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi:" + ex.Message);
                }

            }
        }
    }
}