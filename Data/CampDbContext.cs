using System;
using Microsoft.EntityFrameworkCore;
using CampTiger.Models;

namespace CampTiger.Data
{
    public class CampDbContext : DbContext
    {
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Event> Event { get; set; }
        //public DbSet<UserGroup> UserGroup { get; set; }

        public CampDbContext(DbContextOptions<CampDbContext> options) : base(options) { }
    }
}
