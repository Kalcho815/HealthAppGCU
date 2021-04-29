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

        public OverviewDbManager(HealthAppContext dbContext, PhysicalDbManager physicalDbManager)
        {
            this.dbContext = dbContext;
            this.physicalDbManager = physicalDbManager;
        }

        public void getOverview(DateTime startDate, DateTime endDate, string activityType, string username)
        {
            switch (activityType)
            {
                case "run":
                    this.physicalDbManager.GetOverview(startDate, endDate, activityType, username);
                    //TODO: two different get overview methods in overview controller, depending if healthcare activity or physical activity
                    //TODO: or one viewmodel with 2 lists for the activities
                    break;
                default:
                    break;
            }
        }
    }
}
