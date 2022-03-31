using RebelsTasksDataAccessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.Model
{
    public class MainTask : TaskBase
    {
        public MainTask()
        {
            SubTasks=new List<SubTask>();
        }
        public EmployeeExperience RequiredExperience { get; set; } //Bu iş için gerekli deneyim süresi

        //Tamamlanma Oranı
        public float CompletionRate 
        {
            get
            {
                var dbQuery = (from sub in SubTasks
                              select sub).ToList();

                int counter = 0;
                
                foreach (var item in dbQuery)
                {
                    if (item.CompletedOn!=null)
                    {
                        counter++;
                    }
                }
             
               return counter / dbQuery.Count;
 
            } 
        } 
        
        public override TaskStatus Status {
            get
            {
                if (StartedOn==null)
                {
                 return   TaskStatus.Open;
                }
                else if (CompletedOn!=null)
                {
                    return TaskStatus.Done;
                }
                else
                {           
                    return TaskStatus.InProgress;
                }
            } 
        }


        //Burada herhangi bir tamamlanma veya bitiş süresini elle yazma durumum yok. Alt işlere göre üst işin bitim bitmediğine karar verilecek.

        //Ezilmiş Property
        public override DateTime? StartedOn 
        {
            get
            {
                //İlk alt işin tarihini döndürüp StartedOn'a atadık.
                if (SubTasks.Any(sub => sub.StartedOn != null))
                {
                    var dbQuery = from sub in SubTasks
                                  select sub;

                    dbQuery = dbQuery.Where(sub => sub.StartedOn != null);

                    dbQuery = dbQuery.OrderBy(sub => sub.StartedOn);

                    return dbQuery.First().StartedOn;
                }
                else
                {
                    return null;
                }
            } 
        }

        //Ezilmiş Property
        public override DateTime? CompletedOn 
        {
            get
            {
                //Son tamamlanmış işi ana görevin tamamlanma tarihine yaz. Ayrıca tüm alt işler tamamlanmalı ki ana görevde kapatılsın.
                if (SubTasks.All(sub=>sub.CompletedOn!=null))
                {
                    var dbQuery = SubTasks.Select(sub=>sub);
                    dbQuery = dbQuery.OrderBy(sub => sub.CompletedOn);
                    return dbQuery.Last().CompletedOn;
                }
                else
                {
                    return null;
                }
            } 
        }

        //Her ana görevin bir tane projesi olacak.
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        //Çalışana Atama(Her bir ana görev bir çalışana ait olacak.)
        public int AssignedToEmployeeId { get; set; }
        public Employee AssignedToEmployee { get; set; }

        //Bir ana görevin birden çok alt görevi olabilir
        public ICollection<SubTask> SubTasks { get; } //Ezilmiş Property

    }
}
