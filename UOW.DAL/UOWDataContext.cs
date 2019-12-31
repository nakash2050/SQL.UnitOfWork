using Microsoft.EntityFrameworkCore;
using UOW.DAL.EntityConfigurations;
using UOW.Entities.Domain;

namespace UOW.DAL
{
    public class UOWDataContext : DbContext
    {
        public UOWDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeSkillEntityConfiguration());
        }
    }
}
