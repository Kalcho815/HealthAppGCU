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
        public IActionResult Count(DateTime bedDate, string bedHour, DateTime wakeDate, string wakeHour)
        {
            var username = this.User.Identity.Name;

            bedDate = bedDate.AddHours(double.Parse(bedHour.Substring(0,2)));
            bedDate = bedDate.AddMinutes(double.Parse(bedHour.Substring(3)));

            wakeDate = wakeDate.AddHours(double.Parse(wakeHour.Substring(0, 2)));
            wakeDate = wakeDate.AddMinutes(double.Parse(wakeHour.Substring(3)));

            this.sleepDbManager.RecordSleep(bedDate, wakeDate, username);
            return this.Redirect("/Home/Index");
        }
    }
}
