using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Data;
using Microsoft.AspNetCore.Mvc;

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
            
            return View();
        }
    }
}