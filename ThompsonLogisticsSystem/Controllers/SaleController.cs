using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using ThompsonLogisticsSystem.Models;

namespace ThompsonLogisticsSystem.Controllers
{
    public class SaleController : Controller
    {
       

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult CreateSalesOrder()
        {
            ViewData["Message"] = "Create Sales Order.";

            return View();
        }

        public IActionResult ViewSalesOrders()
        {
            ViewData["Message"] = "My Sales Orders.";
            return View();
        }

        public IActionResult UpdateSalesOrder()
        {
            ViewData["Message"] = "Update Sales Order.";
            return View();
        }

        public IActionResult AddNewCustomer()
        {
            ViewData["Message"] = "Add New Customer.";
            return View();
        }

        public IActionResult UpdateCustomer()
        {
            ViewData["Message"] = "Update Customer Info.";
            return View();
        }

        public IActionResult GenerateReport()
        {
            ViewData["Message"] = "Sales Report.";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
