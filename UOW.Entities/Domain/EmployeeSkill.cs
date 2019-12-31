using UOW.Entities.Enum;

namespace UOW.Entities.Domain
{
    public class EmployeeSkill
    {
        public int SkillId { get; set; }

        public string SkillName { get; set; }

        public Level SkillLevel { get; set; }
    }
}
