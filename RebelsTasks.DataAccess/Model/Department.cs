using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.Model
{
   public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public ICollection<Employee> Employees { get; }
        public override string ToString()
        {
            return DepartmentName;
        }
    }
}
