using HealthAppGCU.DbManagers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class WaterIntakeController : Controller
    {
        private readonly WaterIntakeDbManager waterIntakeDbManager;

        public WaterIntakeController(WaterIntakeDbManager waterIntakeDbManager)
        {
            this.waterIntakeDbManager = waterIntakeDbManager;
        }

        [HttpGet]
        public IActionResult Count()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Count(int milliliters)
        {
            var username = this.User.Identity.Name;

            this.waterIntakeDbManager.AddWaterIntake(milliliters, username);
            return this.Redirect("/Home/Index");

        }
    }
}
