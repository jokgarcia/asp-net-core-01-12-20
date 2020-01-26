using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Data;
using CustomerManagement.Web.ViewModels;
using CustomerManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CustomerManagement.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private IRepositoryLayer repositoryLayer;

        public DepartmentController(IRepositoryLayer _repositoryLayer)
        {
            repositoryLayer = _repositoryLayer;
        }
        public IActionResult Index()
        {
            var viewModel = new DepartmentViewModel();

         //   var department = repositoryLayer.getDepartments();

            //viewModel.Departments = department;

            return View(viewModel);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {

            if (ModelState.IsValid)
            {
                department.IsActive = true;
               // repositoryLayer(department);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int Id, string DepartmentName, string Manager)
        {
            ViewData["Id"] = Id;
            ViewData["DepartmentName"] = DepartmentName;
            ViewData["Manager"] = Manager ;
          
            return View();
        }

    }
}