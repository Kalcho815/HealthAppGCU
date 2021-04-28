using HealthAppGCU.Models;
using HealthAppGCUData.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace HealthAppGCUData
{

    public class HealthAppContext : IdentityDbContext<User,HealthUserRole,string>
    {
        public HealthAppContext(DbContextOptions options) : base(options)
        {
        }

        protected HealthAppContext()
        {
        }


        public DbSet<HealthcareActivity> HealthcareActivities { get; set; }
        public DbSet<PhysicalActivity> PhyiscalActvities { get; set; }

        public DbSet<HealthcareActivityCategory> HealthcareActivityCategories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany(p => p.HealthcareActivities).WithOne(p => p.User);

            //modelBuilder.Entity<User>().HasMany(p => p.PhyiscalActivities).WithOne(p => p.User);
            modelBuilder.Entity<PhysicalActivity>().HasKey(p => p.Id);

        }
    }
}
