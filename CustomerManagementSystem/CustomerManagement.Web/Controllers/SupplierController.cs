using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Data;
using CustomerManagement.Web.Models;
using CustomerManagement.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomerManagement.Web.Controllers
{
    public class SupplierController : Controller
    {
        private IRepositoryLayer repositoryLayer;

        public SupplierController(IRepositoryLayer _repositoryLayer)
        {
            repositoryLayer = _repositoryLayer;
        }
        public IActionResult Index()
        {
            var viewModel = new SupplierViewModel();

            var suppliers = repositoryLayer.GetSuppliers();

            viewModel.Suppliers = suppliers;

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddSupplier()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSupplier(Supplier supplier)
        {

            if (ModelState.IsValid)
            {
                repositoryLayer.AddSupplier(supplier);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id, string SupplierName, string Email)
        {
            ViewData["Id"] = Id;
            ViewData["SupplierName"] = SupplierName;
            ViewData["Email"] = Email;

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Supplier supplier)
        {
            if (ModelState.IsValid)
            {
                repositoryLayer.UpdateSupplier(supplier);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}