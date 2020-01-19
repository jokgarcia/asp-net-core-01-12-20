using BasicCSharp.Models;
using System;

namespace BasicCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate
                var computation = new Computation(); 

            Console.Write("Enter Area : ");
            var area = Console.ReadLine();
            computation.ComputeDeliveryCharge(area);

            Console.Write("Enter First Name : ");
            computation.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            computation.LastName = Console.ReadLine();

            Console.Write("Product Name : ");
            decimal price = 300.50m;
            var product = Console.ReadLine();

            Console.Write("Quantity : ");
            int qty = Convert.ToInt32(Console.ReadLine());
            var charge = computation.Charge;

            //Computation
            var total_amount = (qty * price) + charge;

            Console.WriteLine(computation.FirstName + " " + computation.LastName
                              + " Ordered " + product 
                              + " " + "Total is : " + total_amount);
        }
    }
}
