using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCSharp.Models
{
    public class Order
    {
        //public int Id { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string UnitMeasure { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Charge { get; set; }

        public void ComputeDeliveryCharge(string area)
        {
            if(area != "" || area != null)
            {
                string[] areas = new string[] { "NCR", "CAVITE", 
                                                "LAGUNA", "BULACAN" };
                foreach (var item in areas)
                {
                        switch (area)
                        {
                            case "NCR" : 
                                {
                                Charge = 58.50m;
                                    //Console.WriteLine("Delivery Charge for " + area + " " + 59.50 );
                                    break;
                                }
                            case "CAVITE":
                                {
                                Charge = 77.50m;
                                //Console.WriteLine("Delivery Charge for " + area + " " + 75.00);
                                break;
                                }
                            case "LAGUNA":
                                {
                                Charge = 93.50m;
                                //Console.WriteLine("Delivery Charge for " + area + " " + 70.50);
                                    break;
                                }
                            case "BULACAN":
                                {
                                Charge = 75.50m;
                                //Console.WriteLine("Delivery Charge for " + area + " " + 80.50);
                                    break;
                                }
                            default:
                                {
                                Charge = 100;
                                //Console.WriteLine("Delivery Charge for " + area + " " + 100);
                                break;
                                }

                        }
                    
                    
                    
                }
            }
        }
    }
}
