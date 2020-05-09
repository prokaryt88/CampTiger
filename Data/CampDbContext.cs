using System;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class CampDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public CampDbContext(DbContextOptions<CampDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /*builder.Entity<User>().HasData(
            new
                {
                    UserId = Guid.NewGuid().ToString(),
                    FirstName = "Jane",
                    LastName = "Smith",
                    Address = "123 Oak Ave.",
                    State = "MD",
                    Zip = "21224",
                    Phone = "1234567890"
                }
            );*/
        }
    }


}
