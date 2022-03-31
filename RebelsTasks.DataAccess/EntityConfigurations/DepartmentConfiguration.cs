using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RebelsTasks.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.EntityConfigrations
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(dep => dep.DepartmentId);

            builder.Property(dep => dep.DepartmentName)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(dep => dep.DepartmentDescription)
              .IsRequired()
              .HasColumnType("varchar(4000)");

            builder.HasData(
                new Department() { DepartmentId = 1, DepartmentName = "Yazılım", DepartmentDescription = "Yazılım Ve Kod Geliştirme Depertmanı" },
                new Department() { DepartmentId = 2, DepartmentName = "Proje Analiz", DepartmentDescription = "Proje Analizi ,İş Analizi ve Genel Tasarım" },
                 new Department() { DepartmentId = 3, DepartmentName = "Grafik Ve Arayüzü", DepartmentDescription = "Arayüz Ve Görsel Depertmanı" },
                  new Department() { DepartmentId = 4, DepartmentName = "Yönetim", DepartmentDescription = "Yöneticiler Deperatmanı" }
                );

        }
    }
}
