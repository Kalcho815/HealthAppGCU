using HealthAppGCUData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HealthAppGCU.DbManagers
{
    public class WaterIntakeDbManager
    {
        private readonly HealthAppContext dbContext;

        public WaterIntakeDbManager(HealthAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddWaterIntake(int milliliters, string username)
        {
            var user = dbContext.Users
                .Include(u=>u.HealthcareActivities)
                .Where(u => u.UserName == username)
                .FirstOrDefault();

        user.HealthcareActivities
            .Where(a => a.Date.Day == DateTime.Now.Day)
                .FirstOrDefault()
                .WaterIntake += Math.Abs(milliliters);

            dbContext.SaveChanges();
        }
    }
}
