using UOW.Entities.Enum;

namespace UOW.Entities.DTO
{
    public class EmployeeSkillDTO
    {
        public int SkillId { get; set; }

        public string SkillName { get; set; }

        public Level SkillLevel { get; set; }
    }
}
