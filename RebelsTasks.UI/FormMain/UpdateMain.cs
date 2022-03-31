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
    public partial class UpdateMain : Form
    {
        //*****************************************************************************
        //Sepetimiz
        private readonly List<SubTask> _subTasks = new List<SubTask>();
        //*****************************************************************************
        public UpdateMain()
        {
            InitializeComponent();
        }

        private int _id;
        public UpdateMain(int id )
        {
            _id = id;
            InitializeComponent();
        }

        //************************************************************************************
        //Güncelleme İçin Oluşturulan Alanlar
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var mainTask = FillMainTask();

            if (mainTask != null)
            {
                if (mainTask.AssignedToEmployeeId != 0 && mainTask.Name != null)
                {
                    RebelTaskContext rebelTaskContext = new RebelTaskContext();

                    try
                    {
                        rebelTaskContext.MainTask.Update(mainTask);

                        rebelTaskContext.SaveChanges();

                        MessageBox.Show("Başarı İle Güncellendi.");

                        Close();
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
            else
            {
                MessageBox.Show("Güncellenecek Kayıt Bulunamadı");
            }
        }
        private MainTask FillMainTask()
        {
            RebelTaskContext rebelsTasksContext = new RebelTaskContext();

            var mainTask = rebelsTasksContext.MainTask.Find(_id);

            if (mainTask != null)
            {
                mainTask.Name = txtMainTaskName.Text;

                mainTask.Description = txtMainTaskDescription.Text;

                if (numEmployeeExperience.Value == 0)
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

                if (cmbCustomer.SelectedItem != null)
                {
                    mainTask.AssignedToEmployeeId = (int)cmbCustomer.SelectedValue;
                }

                mainTask.SubTasks.Clear();

                foreach (var item in _subTasks)
                {
                    mainTask.SubTasks.Add(item);
                }
                rebelsTasksContext.SaveChanges();
                return mainTask;
            }
            else
            {
                return null;
            }
        }

        //*************************************************************************************
        //ComboBox İçin Oluşturulan Alanlar

        private void numEmployeeExperience_ValueChanged_1(object sender, EventArgs e)
        {
            GetAllEmployee();
        }
        private void GetAllEmployee()
        {
            cmbCustomer.DataSource = null;

            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            //İlk Bir Verileri Belleğe Çekip Filtreliyor.
            var dbQuery = rebelTaskContext.Employee.AsEnumerable();

            if (numEmployeeExperience.Value == 0)
            {
                dbQuery = dbQuery.Where(emp => emp.EmployeeExperience == EmployeeExperience.None);
            }
            if (numEmployeeExperience.Value <= 2)
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

            FillEmployeeComboBox(dbQuery);
        }
        private void FillEmployeeComboBox(IEnumerable<Employee> employees)
        {
            cmbCustomer.DataSource = employees.ToList();
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "EmployeeId";
        }

        //**************************************************************************************
        //Form Ekranı Yüklenirken Oluşan Olaylar
        private void UpdateMain_Load(object sender, EventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            
            var mainTask=rebelTaskContext.MainTask.Find(_id);

            if (mainTask!=null)
            {
                //Explicit Loading

                rebelTaskContext.Entry(mainTask).Reference(mtk=>mtk.AssignedToEmployee).Load();

                txtMainTaskName.Text = mainTask.Name ;
                txtMainTaskDescription.Text= mainTask.Description;

                FillEmployeeComboBox(mainTask.AssignedToEmployee);

                if (mainTask.RequiredExperience == EmployeeExperience.None)
                {
                    numEmployeeExperience.Value = 0;
                }
                else if (mainTask.RequiredExperience==EmployeeExperience.Junior)
                {
                    numEmployeeExperience.Value = 2;
                }
                else if (mainTask.RequiredExperience == EmployeeExperience.Middle)
                {
                    numEmployeeExperience.Value = 3;
                }
                else if (mainTask.RequiredExperience == EmployeeExperience.Senior)
                {
                    numEmployeeExperience.Value = 6;
                }
                else if (mainTask.RequiredExperience == EmployeeExperience.Principal_Architext)
                {
                    numEmployeeExperience.Value = 11;
                }

                foreach (var item in mainTask.SubTasks)
                {
                    _subTasks.Add(item);
                }

                grdSubTask.AutoGenerateColumns = false;
                grdSubTask.DataSource = _subTasks;

            }
        }
        private void FillEmployeeComboBox(Employee employees)
        {
            List<Employee> employees01 = new List<Employee>();
            employees01.Add(employees);
            cmbCustomer.DataSource = employees01;
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "EmployeeId";
        }

        //***************************************************************************************
        //SubTasks Grid İşlemleri

        private SubTask _subTask = new SubTask();
       
        int counter = 0;
        private void btnAddSubTask_Click(object sender, EventArgs e)
        {
            FillSubTask();

            if (counter == 0)
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
                        counter = counter+1;
                        break;
                    }
                    else if (_subTasks[i].Description == _subTask.Description)
                    {
                        MessageBox.Show("Bu Alt Görev Açıklaması Daha Önce Tanımlanmış");
                        counter = counter + 1;
                        break;
                    }
                }
                if (counter==1)
                {
                    _subTasks.Add(_subTask);
                }
                else if(counter==2)
                {
                    counter = 1;
                }

            }
            RefreshGrid();
        }
      
        private void FillSubTask()
        {
            _subTask.Name = txtSubTaskName.Text;
            _subTask.Description = txtSubTaskDescription.Text;
        }

        private void btnStartedOn_Click_1(object sender, EventArgs e)
        {
            _subTask.Start();
        }

        //Grid Silme
        private void altGörevSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdSubTask.SelectedRows.Count > 0)
            {
                var subTask = (SubTask)(grdSubTask.SelectedRows[0].DataBoundItem);

                if (subTask != null)
                {
                    _subTasks.Remove(subTask);
                    RefreshGrid();
                }
            }
        }

        //SubTasks Refresh Olayı
        private void RefreshGrid()
        {
            grdSubTask.AutoGenerateColumns = false;
            grdSubTask.DataSource = null;
            grdSubTask.DataSource = _subTasks;
            _subTask = new SubTask();
        }


        //Başlangıç Tarihi ve Bitiş Tarihi Atama 
        private void grdSubTask_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var subTask = (SubTask)grdSubTask.SelectedRows[0].DataBoundItem;

            for (int i = 0; i < _subTasks.Count; i++)
            {
                if (_subTasks[i]==subTask)
                {
                    _subTasks.Remove(subTask);
                    break;
                }
            }

            if (subTask!=null)
            {
                //CellContentClick Bir hücrenin içindeki içeriğe tık olduğunda gerçekleşir.
                if (grdSubTask.Columns[e.ColumnIndex].Name == "colStartedsOn")
                {
                    if (subTask.StartedOn==null)
                    {
                        subTask.Start();
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Başlangıç Tarihi Zaten Mevcut");
                    }
                }
                if (grdSubTask.Columns[e.ColumnIndex].Name == "colCompletedsOn")
                {
                    if (subTask.StartedOn != null &&subTask.CompletedOn==null)
                    {
                        subTask.Complete();
                        RefreshGrid();
                    }
                    else
                    {
                        if (subTask.StartedOn == null)
                        {
                            MessageBox.Show("Başlangıç Tarihi Mevcut Değil");
                        }
                        else
                        {
                            MessageBox.Show("Tamalanma Tarihi Zaten Mevcut");
                        }
                    }
                }
            }

            _subTasks.Add(subTask);
            RefreshGrid();
        }

        private void grdSubTask_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdSubTask.SelectedRows.Count > 0)
            {
                grdSubTask.Rows[e.RowIndex].Selected = true;
            }
        }

        //***************************************************************************************




    }
}






 