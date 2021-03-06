using HealthAppGCU.Adaptors;
using HealthAppGCU.Models;
using HealthAppGCUData;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.DbManagers
{
    public class PhysicalDbManager
    {
        private readonly HealthAppContext dbContext;
        private readonly PhysicalActivityAdaptor adaptor;

        public PhysicalDbManager(HealthAppContext dbContext, PhysicalActivityAdaptor adaptor)
        {
            this.dbContext = dbContext;
            this.adaptor = adaptor;
        }

        public void RecordActivity(PhysicalActivityViewModel viewModel, string username)
        {
            var user = dbContext.Users
                .Include(u => u.PhyiscalActivities)
                .Where(u => u.UserName == username)
                .FirstOrDefault();
            
            var physicalActivity = this.adaptor.GetPhysicalActivity(viewModel);
            user.PhyiscalActivities.Add(physicalActivity);
            dbContext.SaveChanges();

            //if (user.PhyiscalActivities.Where(p => p.Date.Day == DateTime.Now.Day && p.Name == "Run").ToList().Count == 0)
            //{

            //}
            //else
            //{
            //    user.PhyiscalActivities[user.PhyiscalActivities.FindIndex(p => p.UserId == physicalActivity.UserId)] = physicalActivity;
            //    dbContext.SaveChanges();
            //}
        }

        public List<PhysicalActivityViewModel> GetOverview(DateTime startDate, DateTime endDate, string activityType, string username)
        {
            var user = dbContext.Users
               .Include(u => u.PhyiscalActivities)
               .Where(u => u.UserName == username)
               .FirstOrDefault();

            var activities = user.PhyiscalActivities.Where(p => p.Name == activityType &&  p.Date <= endDate.AddHours(23).AddMinutes(59).AddMinutes(59) && p.Date >= startDate);//zashtoto kato se izbere edin den to proverqva dali e mejdu 00:00 i 00:00


            var result = new List<PhysicalActivityViewModel>();

            foreach (var activity in activities)
            {
                result.Add(this.adaptor.GetPhysicalActivityViewModel(activity));
            }

            return result;
        }
    }
}
