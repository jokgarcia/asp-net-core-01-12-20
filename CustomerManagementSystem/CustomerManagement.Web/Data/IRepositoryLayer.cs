using System.Collections.Generic;
using CustomerManagement.Web.Models;
using CustomerManagement.Web.ViewModels;

namespace CustomerManagement.Web.Data
{
    public interface IRepositoryLayer
    {
        bool AddCustomer(CustomerViewModel request);
        IEnumerable<Customer> GetCustomers();
    }
}