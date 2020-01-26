using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Models;
using CustomerManagement.Web.ViewModels;
using CustomerManagement.Web.Data;
using Microsoft.AspNetCore.Http;
using CustomerManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerManagement.Web.Controllers
{
    public class ProductController : Controller
    {
        private IRepositoryLayer repositoryLayer;

        public ProductController(IRepositoryLayer _repositoryLayer)
        {
            repositoryLayer = _repositoryLayer;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = new ProductViewModel();

            var products = repositoryLayer.GetProducts();

            viewModel.Products = products;

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {

            if (ModelState.IsValid)
            {
                product.IsActive = true;
                repositoryLayer.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int Id, string ProductName, string Description, string SupplierName)
        {
            ViewData["Id"] = Id;
            ViewData["ProductName"] = ProductName;
            ViewData["Description"] = Description;
            ViewData["SupplierName"] = SupplierName;

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                product.IsActive = true;
                repositoryLayer.UpdateProduct(product);
            }

            return RedirectToAction(nameof(Index));
        }

    }
}

