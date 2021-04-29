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
        private readonly HealtchcareActivityDbManager healtchcareActivityDbManager;

        public WaterIntakeController(WaterIntakeDbManager waterIntakeDbManager, HealtchcareActivityDbManager healtchcareActivityDbManager)
        {
            this.waterIntakeDbManager = waterIntakeDbManager;
            this.healtchcareActivityDbManager = healtchcareActivityDbManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = healtchcareActivityDbManager.GetTodaysActivity();

            return this.View(model);
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
