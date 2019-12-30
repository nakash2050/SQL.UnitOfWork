using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UOW.Entities.Domain;

namespace UOW.DAL.EntityConfigurations
{
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("tblEmployees");
            builder.HasKey(e => e.EmployeeId);

            builder.Property(e => e.FirstName).HasColumnType("VARCHAR").HasMaxLength(100);
            builder.Property(e => e.LastName).HasColumnType("VARCHAR").HasMaxLength(100);
        }
    }
}
