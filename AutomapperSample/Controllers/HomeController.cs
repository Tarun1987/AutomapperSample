using System.Web.Mvc;
using AutomapperSample.Domain;
using AutomapperSample.Models;
using System;

namespace AutomapperSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly DatabaseCaller _databaseCaller;

        public HomeController()
        {
            _databaseCaller = new DatabaseCaller();
        }

        // GET: Home
        public ActionResult Index()
        {
            var _allCustomers = _databaseCaller.GetAllCustomers();
            return View(_allCustomers);
        }

        public ActionResult GetById(int customerId)
        {
            var _customer = _databaseCaller.GetCustomerById(customerId);
            return View(_customer);
        }

        public ActionResult AddCustomer()
        {
            var id = _databaseCaller.GetMaxId() + 1;

            var newCustomer = new CustomerDto { Age = 20, DOB = DateTime.Now, Email = string.Format($"newuser{id}@gmail.com"), FirstName = string.Format($"User{id}"), LastName = "Last", Id = id };
            _databaseCaller.SaveCustomer(newCustomer);

            return View();
        }
    }
}