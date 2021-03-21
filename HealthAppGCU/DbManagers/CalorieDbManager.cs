using HealthAppGCUData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.DbManagers
{
    public class CalorieDbManager
    {
        private readonly HealthAppContext dbContext;

        public CalorieDbManager(HealthAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddCalories(string username, int calories)
        {
            var user = dbContext.Users.Include(u=>u.HealthcareActivities).Where(u => u.UserName == username).FirstOrDefault();

            user.HealthcareActivities.Where(a => a.Date.Day == DateTime.Now.Day).FirstOrDefault()
                .Calories += calories;
            dbContext.SaveChanges();

        }
    }
}
