using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {

            var viewModel = new CustomersViewModel();

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var viewModel = new CustomersViewModel();
            var customer = viewModel.Customers.SingleOrDefault(a => a.Id == id);

            return Content(customer.Name);
        }
    }
}