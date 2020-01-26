using CustomerManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Web.ViewModels
{
    public class CustomerViewModel
    {
      public IEnumerable<Customer> Customers { get; set; }
        public Customer Customer { get; set; }

        public string SearchString { get; set; }
    }
}
