using HealthAppGCU.DbManagers;
using HealthAppGCU.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HealthAppGCU.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HealtchcareActivityDbManager healtchcareActivityDbManager;

        public HomeController(ILogger<HomeController> logger, HealtchcareActivityDbManager healtchcareActivityDbManager)
        {
            _logger = logger;
            this.healtchcareActivityDbManager = healtchcareActivityDbManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                healtchcareActivityDbManager.CheckAndCreateHealthcareActivity();
            }
            else
            {
                return View(new HealthcareActivityViewModel());
            }

            var activityVm = this.healtchcareActivityDbManager.GetTodaysActivity();

            return View(activityVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        //TODO: Running, walking, cycling, swimming 

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
