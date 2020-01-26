using CustomerManagement.Web.Models;
using System.Collections.Generic;

namespace CustomerManagement.Web.Data
{
    public interface IRepositoryLayer
    {
        Customer AddCustomer(Customer customer);
        Product AddProduct(Product product);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<Product> GetProducts();
        IEnumerable<Supplier> GetSuppliers();
        IEnumerable<Customer> SearchCustomer(string search);
        IEnumerable<Product> SearchProduct(string search);
        Customer UpdateCustomer(Customer customer);
        
        // Supplier Interface
        IEnumerable<Supplier> GetSuppliers();
        Supplier AddSupplier(Supplier supplier);
        Supplier UpdateSupplier(Supplier supplier);
        Product UpdateProduct(Product product);
    }
}