using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Models;
using CustomerManagement.Web.Data;
using CustomerManagement.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Web.Controllers
{
    public class CustomerController : Controller
    {
        private IRepositoryLayer repositoryLayer;

        public CustomerController(IRepositoryLayer _repositoryLayer) 
        {
            repositoryLayer = _repositoryLayer;
        }

        // GET: Customer
        public IActionResult Index()
        {
            var viewModel = new CustomerViewModel();

            var customers = repositoryLayer.GetCustomers();

            viewModel.Customers = customers;

            return View(viewModel);
        }

        //[HttpGet]
        //public IActionResult Edit(int id,string FirstName,string LastName)
        //{

        //    return View();
        //}

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            return View();
        }

    }
}