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

        public IActionResult ViewPurchaseOrders()
        {
            ViewData["Message"] = "My Purchase Orders.";
            return View();
        }

        public IActionResult UpdatePurchaseOrder()
        {
            ViewData["Message"] = "Update Purchase Order.";
            return View();
        }

        public IActionResult AddNewVendor()
        {
            ViewData["Message"] = "Add New Vendor.";
            return View();
        }

        public IActionResult UpdateVendor()
        {
            ViewData["Message"] = "Update Vendor Info.";
            return View();
        }

        public IActionResult GenerateReport()
        {
            ViewData["Message"] = "PO Report.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
