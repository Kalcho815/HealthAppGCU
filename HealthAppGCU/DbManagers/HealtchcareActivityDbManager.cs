using HealthAppGCU.Adaptors;
using HealthAppGCU.Models;
using HealthAppGCUData;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
            if (!user.HealthcareActivities.Any(a => a.Date.Date == DateTime.Now.Date))
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
                .Where(a => a.Date.Date == DateTime.Now.Date)
                .FirstOrDefault();

            var activityVm = adaptor.GetActivityViewModel(activity);
            return activityVm;
        }

        public List<HealthcareActivityViewModel> GetOverview(DateTime startDate, DateTime endDate, string activityType, string username)
        {
            var user = dbContext.Users
               .Include(u => u.HealthcareActivities)
               .Where(u => u.UserName == username)
               .FirstOrDefault();

            var activities = user.HealthcareActivities.Where(h => h.Date <= endDate.AddHours(23).AddMinutes(59).AddMinutes(59) && h.Date >= startDate);//zashtoto kato se izbere edin den to proverqva dali e mejdu 00:00 i 00:00


            var result = new List<HealthcareActivityViewModel>();

            foreach (var activity in activities)
            {
                var model = this.adaptor.GetActivityViewModel(activity);
                result.Add(model);
            }

            return result;
        }
    }
}
