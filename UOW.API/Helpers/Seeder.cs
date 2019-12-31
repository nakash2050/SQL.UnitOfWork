using Microsoft.EntityFrameworkCore;
using UOW.DAL;

namespace UOW.API.Helpers
{
    public class Seeder
    {
        private readonly UOWDataContext context;

        public Seeder(UOWDataContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            context.Database.Migrate();
        }
    }
}
