using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UOW.DAL;

namespace UOW.API
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<UOWDataContext>
    {
        private readonly IWebHostEnvironment hostingEnvironment;

        public DesignTimeDbContextFactory(IWebHostEnvironment hostingEnvironment)
        {
            this.hostingEnvironment = hostingEnvironment;
        }

        public UOWDataContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", true, true)
                .Build();
            var builder = new DbContextOptionsBuilder<UOWDataContext>();
            var connectionString = configuration.GetConnectionString("Default");
            builder.UseSqlServer(connectionString);
            return new UOWDataContext(builder.Options);
        }
    }
}
