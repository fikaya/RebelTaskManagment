using RebelsTasks.DataAccess;
using RebelsTasks.UI.FormMain;
using RebelsTasksDataAccessModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RebelsTasks.UI.ProjectForm
{
    public partial class GridProject : Form
    {
        public GridProject()
        {
            InitializeComponent();
        }

        private void GridProject_Load(object sender, EventArgs e)
        {
            RefreshGrid();

        }
        private void RefreshGrid()
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            var dbQuery = rebelTaskContext.Project.ToList();
            grdProject.AutoGenerateColumns = false;
            grdProject.DataSource = null;
            grdProject.DataSource = dbQuery;
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {

            /*
              The LINQ expression 'DbSet<Project>() .Where(p => (int)p.Status == 3)' could not be translated. Additional information: Translation of member 'Status' on entity type 'Project' failed. This commonly occurs when the specified member is unmapped. Either rewrite the query in a form that can be translated, or switch to client evaluation explicitly by inserting a call to 'AsEnumerable', 'AsAsyncEnumerable', 'ToList', or 'ToListAsync'. 
             */

            /*
             'DbSet<Project>() .Where(p => (int)p.Status == 3)' LINQ ifadesi çevrilemedi. Ek bilgi: 'Proje' varlık türü üzerindeki 'Durum' üyesinin çevirisi başarısız oldu. Bu genellikle belirtilen üye eşlenmemiş olduğunda oluşur. Sorguyu çevrilebilecek bir biçimde yeniden yazın ya da 'AsEnumerable', 'AsAsyncEnumerable', 'ToList' veya 'ToListAsync' için bir çağrı ekleyerek açıkça istemci değerlendirmesine geçin.
             */

            /*
         
             AsEnumerable memory de datayı alıyor onun üzerinde işlemleri yapıyor .Status de eğer filtrleme yaparsak onun için problem olmuyor. AsQuerayable da da Sql üzerinde işlemleri yapıp getiriyor.
             */
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            var dbQuery = rebelTaskContext.Project.ToList();

            grdProject.AutoGenerateColumns = false;
            grdProject.DataSource = null;

            if (chkStatus.Checked)
            {
                grdProject.DataSource = dbQuery.Where(proj => proj.Status == ProjectStatus.InProgress).ToList();
            }
            else
            {
                grdProject.DataSource = dbQuery.ToList();
            }
        }

        private void grdEmployee_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdProject.SelectedRows.Count > 0)
            {
                grdProject.Rows[e.RowIndex].Selected = true;
            }
        }

        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            if (grdProject.SelectedRows.Count > 0)
            {
                var project = (Project)grdProject.SelectedRows[0].DataBoundItem;

                var project01 = rebelTaskContext.Project.Find(project.ProjectId);

                if (project01.Status != ProjectStatus.None && project01.Status != ProjectStatus.InProgress && project01.Status != ProjectStatus.Delayed)
                {
                    MessageBox.Show("Bu Proje Kapatıldığı İçin Herhangi Bir İşlem Yapılamaz.");
                }
                else
                {
                    try
                    {
                        if (project01 != null)
                        {
                            rebelTaskContext.Project.Remove(project01);

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
        }

        private void grdEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var project = (Project)grdProject.SelectedRows[0].DataBoundItem;

            if (grdProject.SelectedRows.Count > 0)
            {
                var rebelTaskContext = new RebelTaskContext();
                var project01 = rebelTaskContext.Project.Find(project.ProjectId);

                try
                {
                    if (project01 != null)
                    {
                        UpdateProject updateProject = new UpdateProject(project01.ProjectId);
                        updateProject.Show();
                        updateProject.FormClosed += UpdateProject_FormClosed;
                    }
                    else
                    {
                        MessageBox.Show("Güncellenecek Kayıt Bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi:" + ex.Message);
                }
            }
        }

        private void UpdateProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        private void görevEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdProject.SelectedRows.Count > 0)
            {
                Project project = ((Project)grdProject.SelectedRows[0].DataBoundItem);
                if (project.Status != ProjectStatus.None && project.Status != ProjectStatus.InProgress && project.Status != ProjectStatus.Delayed)
                {
                    MessageBox.Show("Bu Proje Kapatıldığı İçin Herhangi Bir İşlem Yapılamaz.");
                }
                else
                {
                    RebelTaskContext rebelTaskContext = new RebelTaskContext();
                    if (rebelTaskContext.Project.Find(project.ProjectId) != null)
                    {
                        CreateMain createMain = new CreateMain(project.ProjectId);
                        createMain.Show();
                    }
                }
            }
        }

        private void görevListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdProject.SelectedRows.Count > 0)
            {
                Project project = ((Project)grdProject.SelectedRows[0].DataBoundItem);

                    RebelTaskContext rebelTaskContext = new RebelTaskContext();
                    if (rebelTaskContext.Project.Find(project.ProjectId) != null)
                    {
                        GridMain createMain = new GridMain(project.ProjectId);
                        createMain.Show();
                    }
            }
        }
    }
}
