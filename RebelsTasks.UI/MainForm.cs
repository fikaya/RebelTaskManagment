using RebelsTasks.UI.DepartmantForm;
using RebelsTasks.UI.EmployeeForm;
using RebelsTasks.UI.ProjectForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebelsTasks.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void departmanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDepartmant createDepartmant = new CreateDepartmant();
            createDepartmant.Show();
        }

        private void departmanListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridDepartment gridDepartment=new GridDepartment();
            gridDepartment.Show();
        }

        private void çalışanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEmployee createDepartmant = new CreateEmployee();
            createDepartmant.Show();
        }

        private void çalışanListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridEmployee gridDepartment = new GridEmployee();
            gridDepartment.Show();
        }

        private void projeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProject createProject = new CreateProject();
            createProject.Show();
        }

        private void projeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GridProject gridProject = new GridProject();
            gridProject.Show();
        }
    }
}
