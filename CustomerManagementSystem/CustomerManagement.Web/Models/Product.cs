using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Web.Models
{
    public class Product
    {
        //Attributes and Data types
        public int Id { get; set; }
        public string PRoductName { get; set; }
        public string Description { get; set; }
        public string SupplierName { get; set; }
    }
}
