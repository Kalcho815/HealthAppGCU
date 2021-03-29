using HealthAppGCU.DbManagers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class SleepController : Controller
    {
        private readonly SleepDbManager sleepDbManager;

        public SleepController(SleepDbManager sleepDbManager)
        {
            this.sleepDbManager = sleepDbManager;
        }

        [HttpGet]
        public IActionResult Count()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Count(DateTime bedHour, DateTime wakeHour)
        {
            var username = this.User.Identity.Name;

            string input = DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("D2") + "-" + DateTime.Now.AddDays(-2).Day.ToString("D2") + "T00:00";

            this.sleepDbManager.RecordSleep(bedHour, wakeHour, username);
            return this.Redirect("/Home/Index");
        }
    }
}
