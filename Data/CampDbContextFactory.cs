using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using CampTiger.Data;

namespace CampTiger.Models
{
    public class CampDbContextFactory : IDesignTimeDbContextFactory<CampDbContext>
    {
        public CampDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CampDbContext>();
            var connStr = ConfigurationHelper.GetCurrentSettings("ConnectionStrings:CampConnection");
            optionsBuilder.UseSqlServer(connStr);
            return new CampDbContext(optionsBuilder.Options);
        }
    }
}
