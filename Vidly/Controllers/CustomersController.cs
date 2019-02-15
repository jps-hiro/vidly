﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //private ApplicationDbContext _context;

        public CustomersController()
        {
            //_context = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
           // _context.Dispose(disposing);
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();// _context.Customers;

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer{Id = 1, Name = "John Smith"},
                new Customer{Id=2, Name = "Mary Williams" }
            };
        }
    }
}