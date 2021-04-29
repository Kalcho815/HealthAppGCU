using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAppGCU.Controllers
{
    public class PhysicalDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
