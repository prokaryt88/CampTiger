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
        public DbSet<Family> Family { get; set; }
        public DbSet<UserGroups> UserGroups { get; set; }
        public DbSet<UserEvent> UserEvent { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<UserGroups>()
                .HasKey(o => new { o.GroupId, o.UserId });

            modelbuilder.Entity<UserEvent>()
                .HasKey(o => new { o.EventId, o.UserId });
        }

        public CampDbContext(DbContextOptions<CampDbContext> options) : base(options) { }
    }
}