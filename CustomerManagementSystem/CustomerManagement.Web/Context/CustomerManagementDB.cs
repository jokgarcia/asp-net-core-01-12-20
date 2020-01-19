using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerManagement.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagement.Web.Context
{
    public class CustomerManagementDB : DbContext
    {
        //COntstructor
        public CustomerManagementDB(DbContextOptions options) : base(options) 
        {

        }

        //Database Tables
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}
