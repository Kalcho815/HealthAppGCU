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
        private readonly HealtchcareActivityDbManager healtchcareActivityDbManager;

        public WeightController(WeightDbManager weightDbManager, HealtchcareActivityDbManager healtchcareActivityDbManager)
        {
            this.weightDbManager = weightDbManager;
            this.healtchcareActivityDbManager = healtchcareActivityDbManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = this.healtchcareActivityDbManager.GetTodaysActivity();

            return View(model);
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
