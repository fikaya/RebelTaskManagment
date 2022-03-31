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
    public class MainTaskConfiguration : IEntityTypeConfiguration<MainTask>
    {
        public void Configure(EntityTypeBuilder<MainTask> builder)
        {
            builder.HasKey(main=>main.Id);
            builder.Property(main=>main.Name).HasColumnType("varchar(180)").IsRequired();
            builder.Property(main => main.Description).IsRequired();

            builder.OwnsMany
            (
            main=>main.SubTasks,
            (subbuilder) =>
            {
                subbuilder.HasKey(sub=>sub.Id);
                subbuilder.Property(sub => sub.StartedOn).HasColumnType("datetime2(2)");
                subbuilder.Property(sub => sub.CompletedOn).HasColumnType("datetime2(2)");
                subbuilder.WithOwner(main => main.ParentTask).HasForeignKey(main=>main.ParentId);
            }

            );
        }
    }
}
