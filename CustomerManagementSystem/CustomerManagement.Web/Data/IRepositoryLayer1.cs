using CustomerManagement.Web.Models;
using System.Collections.Generic;

namespace CustomerManagement.Web.Data
{
    public interface IRepositoryLayer1
    {
        Customer AddCustomer(Customer customer);
        Product AddProduct(Product product);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Product> GetProducts();
        IEnumerable<Supplier> GetSuppliers();
        IEnumerable<Customer> SearchCustomer(string search);
        IEnumerable<Product> SearchProduct(string search);
        Customer UpdateCustomer(Customer customer);
        Product UpdateProduct(Product product);
    }
}