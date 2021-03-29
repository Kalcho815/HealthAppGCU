using HealthAppGCU.DbManagers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class WeightController : Controller
    {
        private readonly WeightDbManager weightDbManager;

        public WeightController(WeightDbManager weightDbManager)
        {
            this.weightDbManager = weightDbManager;
        }

        [HttpGet]
        public IActionResult Count()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Count(double weight)
        {
            var username = this.User.Identity.Name;

            this.weightDbManager.RecordWeight(weight, username);
            return this.Redirect("/Home/Index");
        }
    }
}
