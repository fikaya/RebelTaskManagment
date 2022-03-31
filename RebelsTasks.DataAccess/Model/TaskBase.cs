using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.Model
{
    public abstract class TaskBase
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string Description { get; set; }
       public abstract DateTime?  StartedOn { get; }
       public abstract DateTime?  CompletedOn { get; }
       public abstract TaskStatus Status { get; }
    }

    public enum TaskStatus
    {
        Open=0,
        InProgress=1,
        Done=2
    }
}
