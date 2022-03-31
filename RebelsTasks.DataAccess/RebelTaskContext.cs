using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RebelsTasks.DataAccess.EntityConfigrations;
using RebelsTasks.DataAccess.EntityConfigurations;
using RebelsTasks.DataAccess.Model;
using RebelsTasksDataAccessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelsTasks.DataAccess
{
    public class RebelTaskContext: DbContext
    {
        private const string ConnectionString = "Server=.;Database=RebelsDb;Integrated Security=true;";
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<MainTask> MainTask { get; set; }
        public DbSet<SubTask> SubTask { get; set; }
        public DbSet<Project> Project { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new MainTaskConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
