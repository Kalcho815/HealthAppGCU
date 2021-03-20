using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class CaloriesController : Controller
    {
        public IActionResult Count()
        {
            return View();
        }
    }
}
