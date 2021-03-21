using HealthAppGCU.DbManagers;
using Microsoft.AspNetCore.Mvc;

namespace HealthAppGCU.Controllers
{
    public class CaloriesController : Controller
    {
        private readonly CalorieDbManager calorieDbManager;

        public CaloriesController(CalorieDbManager calorieDbManager)
        {
            this.calorieDbManager = calorieDbManager;
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
    }

}

