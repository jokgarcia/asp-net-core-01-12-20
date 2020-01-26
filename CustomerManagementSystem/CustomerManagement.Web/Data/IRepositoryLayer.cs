using System.Collections.Generic;
using CustomerManagement.Web.Models;

namespace CustomerManagement.Web.Data
{
    public interface IRepositoryLayer
    {
        Customer AddCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Customer> SearchCustomer(string search);
        Customer UpdateCustomer(Customer customer);

        IEnumerable<Supplier> GetSuppliers();


        Product AddProduct(Product product);
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> SearchProduct(string search);
        Product UpdateProduct(Product product);
    }
}