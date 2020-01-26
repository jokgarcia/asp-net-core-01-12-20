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

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {

            if (ModelState.IsValid)
            {
                var newRoom = new Customer();
                //newRoom.RoomNo = room.RoomNo;
                //newRoom.RoomType = room.RoomType;
                //newRoom.Rate = room.Rate;
                //newRoom.RoomStatus = "Available";

                //newRoom = _reservationData.AddRoom(newRoom);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

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