using CustomerManagement.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Web.Context
{
    public static class DBInitializer
    {
        public static void Initialize(CustomerManagementContext context)
        {
            context.Database.EnsureCreated();

            var customer = new Customer()
            {
                FirstName = "Jok",
                LastName = "Garcia",
                Address = "Q.C",
                Email = "jok@email.com",
                PhoneNumber = "777-555-444",
                IsActive = true
            };

            context.Customers.Add(customer);
            context.SaveChanges();

            var supplier = new Supplier()
            {
                SupplierName = "Samsung",
                Email = "samsung@email.com"
            };

            context.Suppliers.Add(supplier);
            context.SaveChanges();

            //DEPT
            var dept = new Department()
            {
                DepartmentName = "Accounting",
                Manager = "Mr. Reyes"
            };

            context.Departments.Add(dept);
            context.SaveChanges();

            //Product
            var prod = new Product()
            {
                ProductName = "Smsung S10",
                Description = "Phone",
                SupplierName = "Samsung"
            };

            context.Products.Add(prod);
            context.SaveChanges();

        }
    }
}
