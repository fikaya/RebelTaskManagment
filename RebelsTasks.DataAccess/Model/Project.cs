using RebelsTasks.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasksDataAccessModel
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Tahmini Süre Gün Olarak

        private int _estimatedDurationDays;
        public int EstimatedDurationInDays
        {
            get
            {
                return _estimatedDurationDays;
            }
            set
            {
                if (value < 0)
                {
                    //Negatif bir değer giremez
                    _estimatedDurationDays = 0;
                }
                else
                {
                    _estimatedDurationDays = value;
                }
            }
        }
        public DateTime StartDate { get; set; }//Tahmini Başlangıç tarihi
        public DateTime DueDate//Tahmini Bitiş tarihi
        {
            get
            {
                return StartDate.AddDays(_estimatedDurationDays);//Tahmini bitiş süresi hesaplanıyor
            }
        }

        private DateTime? _startedOn;
        public DateTime? StartedOn { get { return _startedOn; } } //Başlama Süresi

        private DateTime? _completedOn;
        public DateTime? CompletedOn { get { return _completedOn; } } //Tamamlanma Süresi

        private DateTime? _closedOn;
       public DateTime? ClosedOn { get { return _closedOn; } }//Kapatma Süresi(Projeyi tam tamına kapattığın zaman)

        public void Start()
        {
            if (_startedOn == null)
            {
                _startedOn = DateTime.Now;
            }
        }
        public void Complete()
        {
            if (_startedOn!=null&&_completedOn == null)
            {
                _completedOn = DateTime.Now;
                 Close();
                //Complete olunca direk close diyeceğiz . Şuan Akış Olarak Böyle İlerliyor. Gerçek hayatta böyle olmasa da şuanlık böyle diyoruz.
            }
        }
        public void Close()
        {
            if (_closedOn == null)
            {
                _closedOn = DateTime.Now;
            }
        }
        public int WorkedDays
        { //Çalışılan GÜn
            get
            {
                if (StartedOn==null)
                {
                    return 0;
                }
                else if (ClosedOn.HasValue==false)//Burada eğer kapanma tarihi atanmamışsa her türlü tamamlanmamıştır mantığını kullandık. Çünkü hatırlarsak Completed metodu çağrıldığında Closed metodu tetikleniyordu.
                {
                    double days = (DateTime.Today - StartedOn.Value).TotalDays;
                    return (int)days;
                }
                else//Burada da ClosedOn için bir değer varsa 
                {
                        double days = (StartedOn.Value - ClosedOn.Value).TotalDays; //Eğer tamamlanmadan kapandı ise niyet gibi düşünebiliriz.
                        return (int)days;
                }
            }
        }
        public int RemainingDays //remaining day kalan gün anlamına geliyor.
        {
            get
            {
                double days = (DueDate.Date - DateTime.Today).TotalDays;
                if (days <= 0)
                {
                    return 0;
                }
                else
                {
                    return (int)days;
                }

            }
        }
        public ProjectStatus Status
        {
            //1.Status => Henüz başlanmayan proje None,
            //Başlamış proje InProgress,
            //Başlamış ve tahmini bitiş tarihi bugünü geçmiş proje Delayed,
            //Başlamış ve zamanında tamamlanmış proje CompletedOnTime,
            //Başlamış ve zamanından sonra tamamlanmış proje CompletedWithDelay,
            //1.Başlamadan kapatılmış proje Closed,
            //Başlamış ancak tamamlanmadan kapanmış proje Cancelled durumunu döndürecek.
            get
            {
                //Today saat almazken now saatini de alıyor. Date ve today aynı.
                if (StartedOn == null)
                {
                    return ClosedOn != null ? ProjectStatus.Closed : ProjectStatus.None;
                }
                else if (ClosedOn == null)
                {
                    return DateTime.Today <= DueDate ? ProjectStatus.InProgress : ProjectStatus.Delayed;
                }
                else if (CompletedOn == null)//Closed On null değil durumunda kapnmış olacak ama tamamlanmayıp kapandıysa bu şekilde oluyor
                {
                    return ProjectStatus.Cancelled;
                }
                else//Burada da CompletedOn null değilse yani tamamlanmışssa kontrolleri yapılıyor.
                {
                    return CompletedOn.Value <= DueDate
                        ? ProjectStatus.CompletedOnTime
                        : ProjectStatus.CompletedWithDelay;
                }
            }
        }
        public ICollection<MainTask> MainTasks { get; }
        //Bir projeninin birden çok fazla görevi olabilir.


        public override string ToString()
        {
            return Name;
        }

    }
    public enum ProjectStatus
    {
        None = 0,
        //Devam ediyor
        InProgress = 1,
        Delayed = 2,
        //Gecikmiş
        CompletedOnTime = 3,
        //Tamamlandı
        CompletedWithDelay = 4,
        //Gecikme ile Tamamlandı.
        Closed = 5,
        Cancelled = 6
    }
}
