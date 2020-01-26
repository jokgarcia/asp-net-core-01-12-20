using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Models;
using CustomerManagement.Web.Data;
using CustomerManagement.Web.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

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
        //[Authorize]
        public IActionResult Index()
        {
            var viewModel = new CustomerViewModel();

            var customers = repositoryLayer.GetCustomers();

            viewModel.Customers = customers;

            return View(viewModel);
        }

        [AllowAnonymous]
        public IActionResult Index(CustomerViewModel customer)
        {
            var model = new CustomerViewModel();
            //if (room.SearchString == "" || room.SearchString == null)
            //{
            //    model.Rooms = _reservationData.GetRooms();
            //    model.GreetGuest = _greeter.GreetGuest();
            //}
            //else
            //{
            model.Customer = repositoryLayer.SearchCustomer(customer.SearchString);
            //}
            return View(model);
        }

        [HttpGet]
        public IActionResult AddCustomer() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {

            if (ModelState.IsValid)
            {
                customer.IsActive = true;
                repositoryLayer.AddCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int Id, string FirstName, string LastName, string Address, string Email, string PhoneNumber)
        {
            ViewData["Id"] = Id;
            ViewData["FirstName"] = FirstName;
            ViewData["LastName"] = LastName;
            ViewData["Address"] = Address;
            ViewData["Email"] = Email;
            ViewData["Address"] = Address;
            ViewData["PhoneNumber"] = PhoneNumber;

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid) 
            {
                customer.IsActive = true;
                repositoryLayer.UpdateCustomer(customer);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}