using UOW.DAL.Concretes;
using UOW.Entities.Domain;
using UOW.Repositories;

namespace UOW.DAL.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly UOWDataContext context;

        public EmployeeRepository(UOWDataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
