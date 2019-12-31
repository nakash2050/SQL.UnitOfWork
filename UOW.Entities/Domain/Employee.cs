using System.Collections.Generic;

namespace UOW.Entities.Domain
{
    public class Employee
    {
        public Employee()
        {
            EmployeeSkills = new HashSet<EmployeeSkill>();
        }

        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Designation { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
