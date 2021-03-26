using HealthAppGCUData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.DbManagers
{
    public class WeightDbManager
    {
        private readonly HealthAppContext dbContext;

        public WeightDbManager(HealthAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void RecordWeight(double weight, string username)
        {
            var user = dbContext.Users
                .Include(u => u.HealthcareActivities)
                .Where(u => u.UserName == username)
                .FirstOrDefault();

            user.HealthcareActivities
                .Where(a => a.Date.Day == DateTime.Now.Day)
                    .FirstOrDefault()
                    .Weight = weight;

            dbContext.SaveChanges();
        }
    }
}
