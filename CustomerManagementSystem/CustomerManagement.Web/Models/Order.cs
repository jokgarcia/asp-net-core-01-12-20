using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CustomerManagement.Web.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string UnitMeasure { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Charge { get; set; }

        
    }
}
