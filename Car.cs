using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string VIN { get; set; }

        public void GetDetails()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Mileage: {Mileage}");
            Console.WriteLine($"VIN: {VIN}");
        }
    }

}
