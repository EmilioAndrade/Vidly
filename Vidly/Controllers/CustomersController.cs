using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Random()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Mary Williams"}
            };

            var viewModel = new RandomCustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}