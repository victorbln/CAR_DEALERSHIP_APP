using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Sale
    {
        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public DateTime SaleDate { get; set; }

        public void GetDetails()
        {
            Console.WriteLine("Sale Details:");
            Console.WriteLine("--------------");
            Console.WriteLine("Car Details:");
            Car.GetDetails();
            Console.WriteLine("\nCustomer Details:");
            Customer.GetDetails();
            Console.WriteLine($"Sale Date: {SaleDate}");
        }
    }

}
