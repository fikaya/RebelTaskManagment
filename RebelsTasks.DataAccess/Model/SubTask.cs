using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.Model
{
    public class SubTask : TaskBase
    {
        public override TaskStatus Status
        {
            get
            {
                if (_startedOn == null)
                {
                    return TaskStatus.Open;
                }
                else if (_completedOn == null)
                {
                    return TaskStatus.InProgress;
                }
                else
                {
                    return TaskStatus.Done;
                }
            }
        }

        private DateTime? _startedOn;
        public override DateTime? StartedOn
        {
            get
            {
                return _startedOn;
            }
        }

        private DateTime? _completedOn;
        public override DateTime? CompletedOn
        {
            get
            {
                return _completedOn;
            }
        }

        public void Start()
        {
            if (_startedOn == null)
            {
                _startedOn = DateTime.Today;
            }
        }
        public void Complete()
        {
            if (_startedOn != null && _completedOn==null)
            {
                _completedOn = DateTime.Today;
            }
         
        }

        public int ParentId { get; set; }
        //Karmaşık tip(MainTask ParentTask) özelliğini bir sınıf içinde tanımladığımızda ve aynı ada sahip özelliği karmaşık tipte Birincil anahtar olarak eklediğimizde, Entity Framework bunu dikkate alır ve özelliği tablonun aynı ada sahip Yabancı anahtarı olarak tanımlar. ParentId ve ParentTask de Parent dan anlıyor.
        public MainTask ParentTask { get; set; }
    }
}
