using CustomerManagement.Web.Models;
using CustomerManagement.Web.Context;
using CustomerManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Web.Data
{
    public class RepositoryLayer : IRepositoryLayer
    {
        CustomerManagementDB context;
        public RepositoryLayer(CustomerManagementDB _context)
        {
            context = _context;
        }

        public bool AddCustomer(CustomerViewModel request)
        {
            bool status = false;

            var customer = new Customer();
            customer.FirstName = request.Customer.FirstName;
            customer.LastName = request.Customer.LastName;

            context.Customers.Add(customer);
            context.SaveChanges();

            return status;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }
    }
}
