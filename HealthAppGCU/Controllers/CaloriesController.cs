using HealthAppGCU.DbManagers;
using Microsoft.AspNetCore.Mvc;

namespace HealthAppGCU.Controllers
{
    public class CaloriesController : Controller
    {
        private readonly CalorieDbManager calorieDbManager;
        private readonly HealtchcareActivityDbManager healtchcareActivityDbManager;

        public CaloriesController(CalorieDbManager calorieDbManager, HealtchcareActivityDbManager healtchcareActivityDbManager)
        {
            this.calorieDbManager = calorieDbManager;
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
        public IActionResult Count(int calories)
        {
            var username = this.User.Identity.Name;

            this.calorieDbManager.AddCalories(username, calories);

            return this.Redirect("/Home/Index");
        }

        //[HttpPost]
        //public IActionResult Delete(int calories)
        //{
        //    var username = this.User.Identity.Name;

        //    this.calorieDbManager.AddCalories(username, calories);

        //    return this.Redirect("/Home/Index");
        //}
    }

}

