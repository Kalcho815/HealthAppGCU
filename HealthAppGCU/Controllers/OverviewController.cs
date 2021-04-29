using HealthAppGCU.DbManagers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class OverviewController : Controller
    {
        private OverviewDbManager dbManager;

        public OverviewController(OverviewDbManager dbManager)
        {
            this.dbManager = dbManager;
        }

        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(DateTime startDate, DateTime endDate, string activityType)
        {
            var username = this.User.Identity.Name;
            this.dbManager.getOverview(startDate, endDate, activityType, username);

            return View();
        }
    }
}
