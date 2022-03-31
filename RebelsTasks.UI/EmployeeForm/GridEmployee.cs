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
    public partial class GridEmployee : Form
    {
        public GridEmployee()
        {
            InitializeComponent();
        }

        private void GridEmployee_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
           
            //Eager Loading
            //Burada SqlServerProfiler da izlediğimiz de Tek bir tane sorgu çalıştırılıp tüm liste içerisinde dönülerek her employee için department alanları dolduruluyor.
            var dbQuery = rebelTaskContext.Employee.Include(emp => emp.Department).ToList();

            //Explicit Loading
            ///Burada SqlServerProfiler da izlediğimiz de her employeenun departmanına ulaşmak için bir bir sorgu çalıştırılıp extra sql e yük bindiriliyor.
      
            //var dbQuery = rebelTaskContext.Employee.ToList();
            //if (dbQuery.Count!=0)
            //{
            //    foreach (var item in dbQuery)
            //    {
            //        rebelTaskContext.Entry(item).Reference(dep => dep.Department).Load();
            //    }
            //}

            grdEmployee.DataSource = null;
            grdEmployee.DataSource = dbQuery;
        }

        private void grdEmployee_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdEmployee.SelectedRows.Count>0)
            {
                grdEmployee.Rows[e.RowIndex].Selected = true;
            }
        }

        //Güncelle
        private void grdEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var employee = (Employee)grdEmployee.SelectedRows[0].DataBoundItem;
           
            if (grdEmployee.SelectedRows.Count > 0)
            {
                var rebelTaskContext = new RebelTaskContext();
                try
                {
                    if (rebelTaskContext.Employee.Find(employee.EmployeeId) != null)
                    {
                        UpdateEmployee updateEmployee = new UpdateEmployee(employee.EmployeeId);
                        updateEmployee.Show();
                        updateEmployee.FormClosed += UpdateEmployee_FormClosed;
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

        private void UpdateEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshGrid();
        }

        //Sil
        private void deleteMenuItem_Click(object sender, EventArgs e)
        {
            RebelTaskContext rebelTaskContext = new RebelTaskContext();

            if (grdEmployee.SelectedRows.Count > 0)
            {
                var employee = (Employee)grdEmployee.SelectedRows[0].DataBoundItem;
                var employee1 = rebelTaskContext.Employee.Find(employee.EmployeeId);
                try
                {
                    if (employee1 != null)
                    {
                        rebelTaskContext.Employee.Remove(employee1);

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
}
