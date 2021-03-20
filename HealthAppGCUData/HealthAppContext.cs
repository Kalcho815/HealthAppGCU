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

        public DbSet<DailyReport> DailyReports { get; set; }

        public DbSet<HealthcareActivity> HealthcareActivities { get; set; }

        public DbSet<HealthcareActivityCategory> HealthcareActivityCategories { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasMany(p => p.DailyReports).WithOne(p => p.User);

          

           
        }
    }
}
