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

namespace RebelsTasks.UI.EmployeeForm
{
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
        }
        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            GetAllDepartment();
            dtpEmployeeHireDate.Value = dtpEmployeeHireDate.Value.AddYears(25);
            dtpEmployeeLeaveDate.Value = dtpEmployeeLeaveDate.Value.AddYears(25);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = FillEmployee();
            if (employee != null)
            {
                try
                {
                    RebelTaskContext rebelTaskContext = new RebelTaskContext();
                    rebelTaskContext.Employee.Add(employee);
                    rebelTaskContext.SaveChanges();
                    MessageBox.Show("Başarı İle Kaydedildi.");
                    Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir Hata Meydana Geldi" + ex.Message);
                }
            }
        }

        private Employee FillEmployee()
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            Employee employee = null;
            if (txtEmployeeFirstName.Text != null && txtEmployeeLastName.Text != null)
            {
                if (rebelTaskContext.Department.Find((int)cmbEmployeeDepartment.SelectedValue) != null)
                {
                    employee = new Employee();
                    employee.EmployeeFirstName = txtEmployeeFirstName.Text;
                    employee.EmployeeLastName = txtEmployeeLastName.Text;
                    employee.DepartmentId = (int)cmbEmployeeDepartment.SelectedValue;
                    employee.Title = txtEmployeeTitle.Text;

                    if (dtpEmployeeHireDate.Value == dtpEmployeeHireDate.Value.AddYears(25))
                    {
                        employee.HireDate = null;
                    }
                    else
                    {
                        employee.HireDate = dtpEmployeeHireDate.Value;
                    }

                    if (dtpEmployeeLeaveDate.Value == dtpEmployeeLeaveDate.Value.AddYears(25))
                    {
                        employee.LeaveDate = null;
                    }
                    else
                    {
                        employee.LeaveDate = dtpEmployeeLeaveDate.Value;
                    }

                    return employee;
                }
            }
            return employee;
        }

        private void GetAllDepartment()
        {
            RebelTaskContext rebelsTaskContext = new RebelTaskContext();
            cmbEmployeeDepartment.DataSource = null;
            cmbEmployeeDepartment.DataSource = rebelsTaskContext.Department.ToList();
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "DepartmentId";
        }

        private void Clear()
        {
            txtEmployeeFirstName.Text = "";
            txtEmployeeLastName.Text = "";
            txtEmployeeTitle.Text = "";
            cmbEmployeeDepartment.SelectedItem = null;
            dtpEmployeeHireDate.Value = dtpEmployeeHireDate.Value.AddYears(25);
            dtpEmployeeLeaveDate.Value = dtpEmployeeLeaveDate.Value.AddYears(25);
        }

    }
}
