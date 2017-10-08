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
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}
            };

            var viewModel = new RandomCustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var viewModel = new CustomerViewModel();

            if (id == 1)
            {
                viewModel.Customer = new Customer { Id = 1, Name = "John Smith" };
                return View(viewModel);
            }
            else if(id == 2)
            {
                viewModel.Customer = new Customer { Id = 2, Name = "Mary Williams" };
                return View(viewModel); ;
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}