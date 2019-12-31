using System;
using System.Threading.Tasks;

namespace UOW.Repositories.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Complete();
    }
}
