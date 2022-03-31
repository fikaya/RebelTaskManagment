using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RebelsTasks.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(emp=>emp.EmployeeId);

            builder.Property(emp => emp.EmployeeFirstName).IsRequired().IsUnicode().HasColumnType("varchar(100)");

            builder.Property(emp=>emp.EmployeeLastName).IsRequired().HasColumnType("varchar(100)");

            builder.Ignore(emp => emp.FullName);

            builder.HasOne(emp => emp.Department).WithMany(dep=>dep.Employees).HasForeignKey(emp => emp.DepartmentId);

            builder.Property(emp => emp.Title).HasColumnType("varchar(100)");

            builder.Property(emp =>emp.LeaveDate).HasColumnType("date");

            builder.Property(emp => emp.HireDate).HasColumnType("date");

            builder.HasData
            (
            new Employee()
            {
                EmployeeId = 1,
                EmployeeFirstName = "Tsubsa",
                EmployeeLastName = "Ozora",
                DepartmentId = 1,
                Title = "Yazılım Geliştiricisi",
                HireDate = DateTime.ParseExact("01.01.2012", "dd.MM.yyyy", null),
                LeaveDate = null
            },
            new Employee()
            {
                EmployeeId = 2,
                EmployeeFirstName = "Misaki",
                EmployeeLastName = "Taro",
                DepartmentId = 1,
                Title = "Yazılım Geliştiricisi",
                HireDate = DateTime.ParseExact("05.10.2015", "dd.MM.yyyy", null),
                LeaveDate = null
            },
            new Employee()
            {
                EmployeeId = 3,
                EmployeeFirstName = "Kojiro",
                EmployeeLastName = "Huga",
                DepartmentId = 1,
                Title = "Yazılım Geliştiricisi",
                HireDate = DateTime.ParseExact("01.05.2014", "dd.MM.yyyy", null),
                LeaveDate = DateTime.ParseExact("01.05.2019", "dd.MM.yyyy", null)
            },
            new Employee()
            {
                EmployeeId = 4,
                EmployeeFirstName = "Sanae",
                EmployeeLastName = " Nakazawa",
                DepartmentId = 2,
                Title = "İş Analisti",
                HireDate = DateTime.ParseExact("16.08.2014", "dd.MM.yyyy", null),
                LeaveDate = null
            },
            new Employee()
            {
                EmployeeId = 5,
                EmployeeFirstName = "Yayoi",
                EmployeeLastName = "Aoba",
                DepartmentId = 2,
                Title = "Yazılım Geliştiricisi",
                HireDate = DateTime.ParseExact("16.08.2014", "dd.MM.yyyy", null),
                LeaveDate = DateTime.ParseExact("05.09.2015", "dd.MM.yyyy", null),
            },
             new Employee()
             {
                 EmployeeId = 6,
                 EmployeeFirstName = "Kumi",
                 EmployeeLastName = "Sugimota",
                 DepartmentId = 3,
                 Title = "Grafik Tasarımcısı",
                 HireDate = DateTime.ParseExact("20.02.2018", "dd.MM.yyyy", null),
                 LeaveDate = null
             },
              new Employee()
              {
                  EmployeeId = 7,
                  EmployeeFirstName = "Roberto",
                  EmployeeLastName="Hongo",
                  DepartmentId = 4,
                  Title = "Proje Yöneticisi",
                  HireDate = DateTime.ParseExact("01.07.2010", "dd.MM.yyyy", null),
                  LeaveDate = null
              },
               new Employee()
               {
                   EmployeeId = 8,
                   EmployeeFirstName = "Munemasa",
                   EmployeeLastName="Mu",
                   DepartmentId = 4,
                   Title = "Ar-Ge Yöneticisi",
                   HireDate = DateTime.ParseExact("01.08.2011", "dd.MM.yyyy", null),
                   LeaveDate = null
               }
            ) ;
        }
    }
}
