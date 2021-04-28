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
            if (user.PhyiscalActivities.Where(p => p.Date == DateTime.Now && p.Name == "Run")==null)
            {
                user.PhyiscalActivities.Add(physicalActivity);
                dbContext.SaveChanges();
            }
        }
    }
}
