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
    public partial class UpdateDepartmant : Form
    {
        public UpdateDepartmant()
        {
            InitializeComponent();
        }
        public int _id;
        public UpdateDepartmant(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void UpdateDepartmant_Load(object sender, EventArgs e)
        {
            var rebelTaskContext = new RebelTaskContext();
            try
            {
                Department department = rebelTaskContext.Department.Find(_id);

                if (department != null)
                {
                    departmanTxt.Text = department.DepartmentName;
                    departmandescriptiontxt.Text = department.DepartmentDescription;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maalesef Bir Hata Meydana Geldi" + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var rebelTaskContext = new RebelTaskContext();

            try
            {
                Department department = rebelTaskContext.Department.Find(_id);

                if (department != null)
                {
                    department.DepartmentName = departmanTxt.Text;
                    department.DepartmentDescription = departmandescriptiontxt.Text;
                    rebelTaskContext.Department.Update(department);
                    rebelTaskContext.SaveChanges();
                    MessageBox.Show("Başarılı İle Güncellendi.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maalesef Bir Hata Meydana Geldi" + ex.Message);
            }
        }
   
    }
}
