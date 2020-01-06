using System.Collections.Generic;

namespace UOW.Entities.DTO
{
    public class AddEmployeeDTO
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Designation { get; set; }

        public List<EmployeeSkillDTO> EmployeeSkills { get; set; }
    }
}
