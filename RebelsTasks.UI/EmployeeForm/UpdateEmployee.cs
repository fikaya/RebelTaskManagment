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

namespace RebelsTasks.UI.EmployeeForm
{
    public partial class UpdateEmployee : Form
    {
        public UpdateEmployee()
        {
            InitializeComponent();
        }
        private int _employeeId;
        public UpdateEmployee(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            GetAllDepartment();

            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            
            var employee = rebelTaskContext.Employee.Find(_employeeId);

            if (employee != null)
            {
                FillEmployee(employee);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = FillEmployee();

           
            if (employee != null)
            {
                try
                {
                    RebelTaskContext rebelTaskContext = new RebelTaskContext();
                    
                    rebelTaskContext.Employee.Update(employee);
                    
                    rebelTaskContext.SaveChanges();

                    MessageBox.Show("Başarı İle Güncellendi.");

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir Hata Meydana Geldi" + ex.Message);
 
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
                    
                    employee.EmployeeId = _employeeId;
                    employee.EmployeeFirstName = txtEmployeeFirstName.Text;
                    employee.EmployeeLastName = txtEmployeeLastName.Text;
                    employee.DepartmentId = (int)cmbEmployeeDepartment.SelectedValue;
                    employee.Title = txtEmployeeTitle.Text;
                    //Bu işlemleri grid ekranında leave date alanı null olduğu zaman üstüne basıp güncelleme ekranını getirmeye çalışırken date time pickera null değer atayamazsınız uyarısından dolayı bunu yaptık.
                    if (dtpEmployeeHireDate.Value == DateTime.Today.AddDays(365))
                    {
                        employee.HireDate = null;
                    }
                    else
                    {
                        employee.HireDate = dtpEmployeeHireDate.Value;
                    }
                    if (dtpEmployeeLeaveDate.Value == DateTime.Today.AddDays(365))
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

        //Form yüklenirken doldurmak adına bunu uyguladım. Overloading
        private void FillEmployee(Employee employee)
        {
            txtEmployeeFirstName.Text = employee.EmployeeFirstName;
            txtEmployeeLastName.Text = employee.EmployeeLastName;
            cmbEmployeeDepartment.SelectedValue = employee.DepartmentId;
            txtEmployeeTitle.Text = employee.Title;
            dtpEmployeeHireDate.Value = employee.HireDate.HasValue?employee.HireDate.Value:DateTime.Today.AddDays(365);
            dtpEmployeeLeaveDate.Value = employee.LeaveDate.HasValue?employee.LeaveDate.Value:DateTime.Today.AddDays(365);
        }

        //Departmant combobox ı dolsun diye bunu yaptım.
        private void GetAllDepartment()
        {
            RebelTaskContext rebelsTaskContext = new RebelTaskContext();
            cmbEmployeeDepartment.DataSource = null;
            cmbEmployeeDepartment.DataSource = rebelsTaskContext.Department.ToList();
            cmbEmployeeDepartment.DisplayMember = "DepartmentName";
            cmbEmployeeDepartment.ValueMember = "DepartmentId";
        }

      
    }
}
