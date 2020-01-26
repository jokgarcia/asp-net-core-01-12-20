using CustomerManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Web.ViewModels
{
    public class DepartmentViewModel
    {
        public IEnumerable<Department> Departments { get; set; }
        public Department Department { get; set; }
    }
}
