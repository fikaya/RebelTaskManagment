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
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        private Project _project = new Project();
        private void btnSave_Click(object sender, EventArgs e)
        {
            var project = FillProject();
            if (project.Name != null)
            {
                try
                {
                    RebelTaskContext rebelTaskContext = new RebelTaskContext();
                    rebelTaskContext.Project.Add(project);
                    rebelTaskContext.SaveChanges();
                    MessageBox.Show("Başarı İle Kaydedildi.");
                    Clear();
                    _project = new Project();
                    button1.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            _project.Start();
            button1.Enabled = false;
        }

        private Project FillProject()
        {
            _project.Name = txtProjectName.Text;
            _project.Description = txtProjectDescription.Text;
            _project.EstimatedDurationInDays = (int)numEstimatedDuration.Value;
            _project.StartDate = dtpStartDate.Value;

            return _project;
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
