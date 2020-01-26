﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Data;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}