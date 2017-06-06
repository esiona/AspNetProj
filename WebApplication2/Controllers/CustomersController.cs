using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer {Name="John Smiths"},
                new Customer {Name="Mary Williams"}
            };
            ViewBag.customers = customers;
            return View();
        }
    }
}