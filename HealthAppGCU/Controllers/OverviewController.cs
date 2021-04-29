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
        public IActionResult Details(DateTime fromDate, DateTime toDate, string activityType)
        {
            var username = this.User.Identity.Name;
            var physicalActivities = this.dbManager.GetPhysicalOverview(fromDate, toDate, activityType, username);
            var healthcareActivities = this.dbManager.GetHealthcareOverview(fromDate, toDate, activityType, username);
            ViewData["PhysicalActivities"] = physicalActivities;
            ViewData["HealthcareActivities"] = healthcareActivities;
            ViewData["activityType"] = activityType;

            return View();
        }
    }
}
