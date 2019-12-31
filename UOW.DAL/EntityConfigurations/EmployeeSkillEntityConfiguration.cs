using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UOW.Entities.Domain;

namespace UOW.DAL.EntityConfigurations
{
    public class EmployeeSkillEntityConfiguration :IEntityTypeConfiguration<EmployeeSkill>
    {
        public void Configure(EntityTypeBuilder<EmployeeSkill> builder)
        {
            builder.ToTable("tblEmployeeSkills");
            builder.HasKey(s => s.SkillId);
            builder.Property(s => s.SkillName).HasColumnType("VARCHAR(100)").IsRequired(true);
            builder.Property(s => s.SkillLevel).IsRequired(true);
        }
    }
}
