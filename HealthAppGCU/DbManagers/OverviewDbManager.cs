using HealthAppGCU.Models;
using HealthAppGCUData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.DbManagers
{
    public class OverviewDbManager
    {
        private readonly HealthAppContext dbContext;
        private readonly PhysicalDbManager physicalDbManager;
        private readonly HealtchcareActivityDbManager healthcareDbManager;

        public OverviewDbManager(HealthAppContext dbContext, PhysicalDbManager physicalDbManager, HealtchcareActivityDbManager healthcareDbManager)
        {
            this.dbContext = dbContext;
            this.physicalDbManager = physicalDbManager;
            this.healthcareDbManager = healthcareDbManager;
        }

        public List<PhysicalActivityViewModel> GetPhysicalOverview(DateTime startDate, DateTime endDate, string activityType, string username)
        {
            var result = this.physicalDbManager.GetOverview(startDate, endDate, activityType, username);

            return result;
        }

        public List<HealthcareActivityViewModel> GetHealthcareOverview(DateTime startDate, DateTime endDate, string activityType, string username)
        {
            var result = this.healthcareDbManager.GetOverview(startDate, endDate, activityType, username);
            return result;
        }
    }
}