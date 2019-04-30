using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using ThompsonLogisticsSystem.Models;

namespace ThompsonLogisticsSystem.Controllers
{
    public class PurchasingController : Controller
    {
       

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult CreatePurchaseOrder()
        {
            ViewData["Message"] = "Please select a vendor to start creating a new purchase order.";

            return View();
        }
               

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
