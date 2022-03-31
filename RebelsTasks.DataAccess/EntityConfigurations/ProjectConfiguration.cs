using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RebelsTasksDataAccessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess.EntityConfigurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
     

        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(proj => proj.ProjectId);
            
            builder.Property(prj => prj.Name).IsRequired().HasMaxLength(100);
            builder.Property(proj => proj.StartDate).HasColumnType("date");
            //builder.Property(proj => proj.DueDate).HasColumnType("date");
            builder.Property(proj =>proj.StartedOn).HasColumnType("datetime2(2)");
            builder.Property(proj => proj.ClosedOn).HasColumnType("datetime2(2)");
            builder.Property(proj => proj.CompletedOn).HasColumnType("datetime2(2)");
           
        }


    }
}
