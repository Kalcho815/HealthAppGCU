using HealthAppGCUData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.DbManagers
{
    public class SleepDbManager
    {
        private readonly HealthAppContext dbContext;

        public SleepDbManager(HealthAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void RecordSleep(DateTime bedHour, DateTime wakeHour, string username)
        {
            var user = dbContext.Users
                .Include(u => u.HealthcareActivities)
                .Where(u => u.UserName == username)
                .FirstOrDefault();

            user.HealthcareActivities
                .Where(a => a.Date.Day == DateTime.Now.Day)
                    .FirstOrDefault()
                    .BedHour = bedHour;

            user.HealthcareActivities
                .Where(a => a.Date.Day == DateTime.Now.Day)
                    .FirstOrDefault()
                    .WakeHour = wakeHour;



            dbContext.SaveChanges();
        }
    }
}
