using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string Title { get; set; }
        public string FullName { get { return EmployeeFirstName + " " + EmployeeLastName; } }
        public EmployeeExperience EmployeeExperience {
            get
            {
                if (HireDate == null)
                {
                    return EmployeeExperience.None;
                }
                else
                {
                    double exp = 0;

                    if (LeaveDate!=null)
                    {
                        exp = (LeaveDate.Value - HireDate.Value).TotalDays / 365.25;
                    }
                    else
                    {
                        exp= (DateTime.Today - HireDate.Value).TotalDays / 365.25;
                    }
                  
                    if (exp <= 2)
                    {
                        return EmployeeExperience.Junior;
                    }
                    else if (exp > 2 || exp <= 5)
                    {
                        return EmployeeExperience.Middle;
                    }
                    else if (exp > 5 || exp <= 10)
                    {
                        return EmployeeExperience.Senior;
                    }
                    else
                    {
                        return EmployeeExperience.Principal_Architext;
                    }
                }
                   
            }
        }
      
        private DateTime? _hireDate;
        public DateTime? HireDate 
        
        {
            get
            {
                return _hireDate;
            }

            set 
            {
                _hireDate = value;
                if (value==null)
                {
                    _leaveDate = null;
                }
               
            }
        
        }

        private DateTime? _leaveDate;
        public DateTime? LeaveDate
        {
            get { return _leaveDate; }
            set
            {
                if (HireDate != null)
                {
                    _leaveDate = value;
                }
                else
                {
                    _leaveDate = null;
                }
            }
        }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public override string ToString()
        {
            return FullName;
        }
 
    }
    public enum EmployeeExperience
    {
        None = 0,
        Junior=1,
        Middle = 2,
        Senior = 3,
        Principal_Architext = 4
    }

   
    
}
