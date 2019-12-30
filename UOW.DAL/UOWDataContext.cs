using Microsoft.EntityFrameworkCore;

namespace UOW.DAL
{
    public class UOWDataContext : DbContext
    {
        public UOWDataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
