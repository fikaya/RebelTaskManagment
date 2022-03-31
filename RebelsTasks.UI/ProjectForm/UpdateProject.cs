using Microsoft.EntityFrameworkCore;
using RebelsTasks.DataAccess;
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
    public partial class UpdateProject : Form
    {
        public UpdateProject()
        {
            InitializeComponent();
        }
        private int _id;
        public UpdateProject(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateProject_Load(object sender, EventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            var project = rebelTaskContext.Project.Include(proj => proj.MainTasks).FirstOrDefault(proj => proj.ProjectId == _id);

            if (project != null)
            {
                FillProject(project);
                _project = project;

                if (project.Status!=ProjectStatus.None&&project.Status!=ProjectStatus.InProgress&&project.Status!=ProjectStatus.Delayed)
                {
                    MessageBox.Show("Bu Proje Kapatıldığı İçin Herhangi Bir GÜncelleme İşlemi Yapılamaz.");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Maalesef Herhangi Bir Kayıt Bulunamadı");
                Close();
            }
        }

        private void FillProject(Project project)
        {
            btnStartedOn.Visible = false;
            btnCompletedOn.Visible = false;

            dtpStartDate.Value = project.StartDate.Date;
            dtpStartDate.Enabled = false;

            txtProjectName.Text = project.Name;
            txtProjectDescription.Text = project.Description;
            numEstimatedDuration.Value = project.EstimatedDurationInDays;

            int counter = 0;

            if (project.StartedOn.HasValue)
            {
                if (project.MainTasks.Count > 0)
                {
                    foreach (var item in project.MainTasks)
                    {
                        if (item.CompletedOn != null)
                        {
                            counter = counter + 1;
                        }
                    }

                    if (counter == project.MainTasks.Count)
                    {
                        btnCompletedOn.Visible = true;
                    }

                    else
                    {
                        btnCompletedOn.Visible = false;
                    }
                }
                else
                {
                    btnCompletedOn.Visible = true;
                }
            }
            else
            {
                btnStartedOn.Visible = true;
                btnCompletedOn.Visible = false;
            }

        }

        private Project _project=new Project();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillProject();

            if (_project.Name != null)
            {
                try
                {
                    RebelTaskContext rebelTaskContext = new RebelTaskContext();
                    rebelTaskContext.Project.Update(_project);
                    rebelTaskContext.SaveChanges();
                    MessageBox.Show("Başarı İle Güncellendi.");
                    Clear();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Proje İsmini Giriniz.");
            }
        }

        private void FillProject()
        {
            _project.Name = txtProjectName.Text;
            _project.Description = txtProjectDescription.Text;
            _project.EstimatedDurationInDays = (int)numEstimatedDuration.Value;
        }

        private void btnStartedOn_Click(object sender, EventArgs e)
        {
            if (_project != null)
            {
                _project.Start();
            }
            btnStartedOn.Enabled = false;
        }

        private void btnClosedOn_Click(object sender, EventArgs e)
        {

            if (_project != null)
            {
                _project.Close();
 
                 InputEnabled();
            }

            btnCompletedOn.Enabled = false;
            btnClosedOn.Enabled = false;
            btnStartedOn.Enabled = false;

        }

        private void btnCompletedOn_Click(object sender, EventArgs e)
        {

            if (_project != null)
            {
                _project.Complete();
 
                 InputEnabled();
            }
            btnCompletedOn.Enabled = false;
        }

        private void InputEnabled()
        {
            txtProjectDescription.Enabled = false;
            txtProjectName.Enabled = false;
            numEstimatedDuration.Enabled = false;
        }
        private void Clear()
        {
            txtProjectDescription.Text = "";
            txtProjectName.Text = "";
            numEstimatedDuration.Text = "";
            dtpStartDate.Value = DateTime.Today;
        }
    }
}


