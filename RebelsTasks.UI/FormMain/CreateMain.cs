using RebelsTasks.DataAccess;
using RebelsTasks.DataAccess.Model;
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

namespace RebelsTasks.UI.FormMain
{
    public partial class CreateMain : Form
    {
        public CreateMain()
        {
            InitializeComponent();
        }
        private int _id;
        public CreateMain(int id)
        {
            _id = id;
            InitializeComponent();
        }
        private readonly List<SubTask> _subTasks = new List<SubTask>();

        private SubTask _subTask = new SubTask();

        int counter = 0;
        private void subTaskSave_Click(object sender, EventArgs e)
        {
            FillSubTask();
            
            if (counter==0)
            {
                _subTasks.Add(_subTask);
                counter = counter + 1;
            }
            else
            {
                for (int i = 0; i < _subTasks.Count; i++)
                {
                    if (_subTasks[i].Name == _subTask.Name)
                    {
                        MessageBox.Show("Bu Alt Görev İsmi Daha Önce Tanımlanmış");
                        counter = counter + 1;
                        break;
                    }
                    else if (_subTasks[i].Description == _subTask.Description)
                    {
                        MessageBox.Show("Bu Alt Görev Açıklaması Daha Önce Tanımlanmış");
                        counter = counter + 1;
                        break;
                    }
                }
                if (counter == 1)
                {
                    _subTasks.Add(_subTask);
                }
                else if (counter == 2)
                {
                    counter = 1;
                }

            }

            DataSourceSubTask();
        }
        private void DataSourceSubTask()
        {
            grdSubTask.AutoGenerateColumns = false;
            grdSubTask.DataSource = null;
            grdSubTask.DataSource = _subTasks;
            _subTask = new SubTask();
        }
        private void FillSubTask()
        {
            _subTask.Name = txtSubTaskName.Text;
            _subTask.Description = txtSubTaskDescription.Text;
        }
        private void btnStartedOn_Click(object sender, EventArgs e)
        {
            _subTask.Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var mainTask = FillMainTask();
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
        
                if (mainTask.AssignedToEmployeeId != 0 && mainTask.Name != null)
                {
                    try
                    {
                        if (mainTask.SubTasks.Count != 0)
                        {
                            rebelTaskContext.Add(mainTask);
                            rebelTaskContext.SaveChanges();
                            MessageBox.Show("Başarı İle Kaydedildi.");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Lütfen Bir Alt Görev Ekleyeniz. Buna Mecbursunuz.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir Hata Meydana Geldi" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Görev Atanacak Kişi Ve Görev İsmi Belirtlilmelidir.");
                }

        }

        private MainTask FillMainTask()
        {
            MainTask mainTask = new MainTask();

            mainTask.Name = txtMainTaskName.Text;
            mainTask.Description = txtMainTaskDescription.Text;
           
            if (numEmployeeExperience.Value ==0)
            {
                mainTask.RequiredExperience = EmployeeExperience.None;
            }
            else if (numEmployeeExperience.Value <= 2)
            {
                mainTask.RequiredExperience = EmployeeExperience.Junior;
            }
            else if (numEmployeeExperience.Value > 2 && numEmployeeExperience.Value <= 5)
            {
                mainTask.RequiredExperience = EmployeeExperience.Middle;
            }
            else if (numEmployeeExperience.Value > 5 && numEmployeeExperience.Value <= 10)
            {
                mainTask.RequiredExperience = EmployeeExperience.Senior;
            }
            else if (numEmployeeExperience.Value > 10)
            {
                mainTask.RequiredExperience = EmployeeExperience.Principal_Architext;
            }

            mainTask.ProjectId = _id;
            
            if (cmbCustomer.SelectedItem != null)
            {
                mainTask.AssignedToEmployeeId = (int)cmbCustomer.SelectedValue;
            }

            foreach (var item in _subTasks)
            {
                mainTask.SubTasks.Add(item);
            }
            
            return mainTask;
        }

        private void GetAllEmployee()
        {
            cmbCustomer.DataSource = null;

            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            //Burası da sorulacak
            //AsQueryable da patlıyor
            var dbQuery = rebelTaskContext.Employee.AsEnumerable();

            if (numEmployeeExperience.Value == 0)
            {
                dbQuery = dbQuery.Where(emp => emp.EmployeeExperience == EmployeeExperience.None);
            }
            else if (numEmployeeExperience.Value <= 2)
            {
                dbQuery = dbQuery.Where(emp => emp.EmployeeExperience == EmployeeExperience.Junior);
            }
            else if (numEmployeeExperience.Value > 2 && numEmployeeExperience.Value <= 5)
            {
                dbQuery = dbQuery.Where(emp => emp.EmployeeExperience == EmployeeExperience.Middle);
            }
            else if (numEmployeeExperience.Value > 5 && numEmployeeExperience.Value <= 10)
            {
                dbQuery = dbQuery.Where(emp => emp.EmployeeExperience == EmployeeExperience.Senior);
            }
            else if (numEmployeeExperience.Value > 10)
            {
                dbQuery = dbQuery.Where(emp => emp.EmployeeExperience == EmployeeExperience.Principal_Architext);
            }

            cmbCustomer.DataSource = dbQuery.ToList();
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "EmployeeId";
        }
        private void altGörevSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdSubTask.SelectedRows.Count > 0)
            {
                var subTask = (SubTask)(grdSubTask.SelectedRows[0].DataBoundItem);

                if (subTask != null)
                {
                    _subTasks.Remove(subTask);
                    DataSourceSubTask();
                }
            }
        }
        private void numEmployeeExperience_ValueChanged(object sender, EventArgs e)
        {
            GetAllEmployee();
        }
 
    }
}
