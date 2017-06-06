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

            var customers = GetCustomers();
         
            //ViewBag.customers = customers;
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault( c => c.Id == id);

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {
                    Name ="John Smiths", Id =1
                },
                new Customer {
                    Name ="Mary Williams",
                    Id =2
                }
            };
        }

       
    }
}