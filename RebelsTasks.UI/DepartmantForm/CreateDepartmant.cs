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
    public partial class CreateDepartmant : Form
    {
        public CreateDepartmant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Department departman = getDepartmant();
            RebelTaskContext rebelTaskContext = new RebelTaskContext();
            try
            {
                rebelTaskContext.Department.Add(departman);
                rebelTaskContext.SaveChanges();
                MessageBox.Show("Başarı İle Kaydedildi.");
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maalesef Bir Hata Meydana Geldi" + ex.Message);
            }
        }

        private Department getDepartmant()
        {
            Department departman = new Department();
            departman.DepartmentName = departmanTxt.Text;
            departman.DepartmentDescription = departmandescriptiontxt.Text;
            return departman;
        }
        private void Clear()
        {
            departmanTxt.Text = "";
            departmandescriptiontxt.Text = "";
        }
    }
}
