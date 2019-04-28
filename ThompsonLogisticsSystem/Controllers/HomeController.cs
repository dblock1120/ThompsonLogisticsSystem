using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using ThompsonLogisticsSystem.Models;

namespace ThompsonLogisticsSystem.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Purchasing()
        {
            ViewData["Message"] = "Welcome to the Purchasing Hub!";

            return View();
        }

        public IActionResult Sales()
        {
            ViewData["Message"] = "Welcome to the Sales Hub!";

            return View();
        }

        public IActionResult Operations()
        {
            ViewData["Message"] = "Welcome to the Operations Hub!";

            return View();
        }

        public IActionResult Admin()
        {
            ViewData["Message"] = "Welcome to System Administration!";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
