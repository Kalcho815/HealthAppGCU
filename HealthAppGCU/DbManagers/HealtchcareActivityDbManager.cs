using HealthAppGCU.Adaptors;
using HealthAppGCU.Models;
using HealthAppGCUData;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HealthAppGCU.DbManagers
{
    public class HealtchcareActivityDbManager
    {
        private readonly HealthAppContext dbContext;
        private readonly HealthcareActivityAdaptor adaptor;
        private readonly IHttpContextAccessor httpContext;
        private User user;

        public HealtchcareActivityDbManager(HealthAppContext dbContext, HealthcareActivityAdaptor adaptor, IHttpContextAccessor httpContextAccessor)
        {
            this.dbContext = dbContext;
            this.adaptor = adaptor;
            this.httpContext = httpContextAccessor;
            var username = httpContext.HttpContext.User.Identity.Name;
            this.user = dbContext.Users.Include(u => u.HealthcareActivities).Where(u => u.UserName == username).FirstOrDefault();
        }

        public void CheckAndCreateHealthcareActivity()
        {
            //TODO: DAY + MONTH + YEAR
            if (!user.HealthcareActivities.Any(a => a.Date == DateTime.Now))
            {
                user.HealthcareActivities.Add(
                    new HealthcareActivity
                    {
                        UserId = user.Id,
                        User = user,
                        Date = DateTime.Now
                    });
                dbContext.SaveChanges();
            }
        }

        public HealthcareActivityViewModel GetTodaysActivity()
        {
            var activity = user.HealthcareActivities
                .Where(a => a.Date.Day == DateTime.Now.Day)
                .FirstOrDefault();

            var activityVm = adaptor.GetActivityViewModel(activity);
            return activityVm; 
        }
    }
}
