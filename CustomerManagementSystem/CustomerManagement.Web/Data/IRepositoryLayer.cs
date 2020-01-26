using System.Collections.Generic;
using CustomerManagement.Web.Models;

namespace CustomerManagement.Web.Data
{
    public interface IRepositoryLayer
    {
        Customer AddCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Department> GetDepartments();
        IEnumerable<Product> GetProducts();
        IEnumerable<Supplier> GetSuppliers();
        IEnumerable<Customer> SearchCustomer(string search);
        Customer UpdateCustomer(Customer customer);
    }
}