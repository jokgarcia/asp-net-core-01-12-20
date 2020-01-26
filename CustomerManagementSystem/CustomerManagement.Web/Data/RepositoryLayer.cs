using CustomerManagement.Web.Models;
using CustomerManagement.Web.Context;
using CustomerManagement.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Web.Data
{
    public class RepositoryLayer : IRepositoryLayer
    {
        CustomerManagementContext context;
        public RepositoryLayer(CustomerManagementContext _context)
        {
            context = _context;
        }

        public Customer AddCustomer(Customer customer)
        {

            context.Customers.Add(customer);
            context.SaveChanges();

            return customer;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return context.Customers.ToList();
        }

        public IEnumerable<Customer> SearchCustomer(string search)
        {
            var result = from c in context.Customers
                         where (c.FirstName.Contains(search))
                         select c;
            return result.ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            context.Attach(customer).State = EntityState.Modified;
            context.SaveChanges();
            return customer;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return context.Suppliers.ToList();
        }

        public Product AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();

            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }

        public IEnumerable<Product> SearchProduct(string search)
        {
            var result = from p in context.Products
                         where (p.ProductName.Contains(search))
                         select p;
            return result;
        }

        public Product UpdateProduct(Product product)
        {
            context.Attach(product).State = EntityState.Modified;
            context.SaveChanges();
            return product;
        }
    }
        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }
        public IEnumerable<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }

}
