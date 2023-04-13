using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_DEALERSHIP.ModelsLibrary
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        public DateTime? SoldDate { get; set; }
        public string BuyerName { get; set; }

        public Car() { }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Car(int id, string make, string model, int year, decimal price)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Car(int id, string make, string model, int year, decimal price, bool isSold, DateTime? soldDate, string buyerName)
        {
            Id = id;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            IsSold = isSold;
            SoldDate = soldDate;
            BuyerName = buyerName;
        }
    }


}
