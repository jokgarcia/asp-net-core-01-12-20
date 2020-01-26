using CustomerManagement.Web.Models;
using System.Collections.Generic;

namespace CustomerManagement.Web.Data
{
    public interface IRepositoryLayer
    {
        Customer AddCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Supplier> GetSuppliers();
        IEnumerable<Customer> SearchCustomer(string search);
        Customer UpdateCustomer(Customer customer);
    }
}