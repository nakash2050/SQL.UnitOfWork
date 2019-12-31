using System.Threading.Tasks;
using UOW.DAL.Repositories;
using UOW.Repositories;
using UOW.Repositories.Contracts;

namespace UOW.DAL.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UOWDataContext context;

        public UnitOfWork(UOWDataContext context)
        {
            this.context = context;
            Initialize();
        }

        public IEmployeeRepository Employees { get; private set; }

        public void Initialize()
        {
            Employees = new EmployeeRepository(context);
        }

        public async Task<int> Complete()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
