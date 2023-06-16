using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class SalesManager
    {
        private List<Sale> sales;

        public SalesManager()
        {
            sales = new List<Sale>();
        }

        public bool AddSale(Sale sale)
        {
            sales.Add(sale);
            SaveSalesToFile();
            return true;
        }

        public List<Sale> GetSalesByMonth(int month, int year)
        {
            return sales
                .Where(sale => sale.SaleDate.Month == month && sale.SaleDate.Year == year)
                .ToList();
        }
        public List<Sale> GetAllSales()
        {
            return sales;
        }

        private void SaveSalesToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("sales.txt", true))
                {
                    foreach (Sale sale in sales)
                    {
                        writer.WriteLine($"Sale Date: {sale.SaleDate}");
                        writer.WriteLine($"Car: {sale.Car.Make} {sale.Car.Model} {sale.Car.Year} {sale.Car.Price} {sale.Car.Color} {sale.Car.VIN} {sale.Car.Mileage}");
                        writer.WriteLine($"Customer: {sale.Customer.Name} {sale.Customer.Email} {sale.Customer.Phone}");
                        writer.WriteLine();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while saving sales to file: {e.Message}");
            }
        }
        public void LoadSalesFromFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader("sales.txt"))
                {
                    string line;
                    Sale sale = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Create a new Sale object
                        sale = new Sale();
                        if(sales.Count > 0)
                        {
                            line = reader.ReadLine();
                        }
                            if (line.StartsWith("Sale Date: "))
                            {
                                // Parse the sale date
                                string dateString = line.Substring("Sale Date: ".Length);
                                sale.SaleDate = DateTime.Parse(dateString);
                            }
                        
                        if ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("Car: "))
                            {
                                // Parse the car details
                                string carDetails = line.Substring("Car: ".Length);
                                string[] carData = carDetails.Split(' ');

                                Car car = new Car
                                {
                                    Make = carData[0],
                                    Model = carData[1],
                                    Year = int.Parse(carData[2]),
                                    Price = decimal.Parse(carData[3]),
                                    Color = carData[4],
                                    VIN = carData[5],
                                    Mileage = int.Parse(carData[6]),
                                };

                                sale.Car = car;
                            }
                        }
                        else
                        {
                            return;
                        }
                        if ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("Customer: "))
                            {
                                // Parse the customer details
                                string customerDetails = line.Substring("Customer: ".Length);
                                string[] customerData = customerDetails.Split(' ');

                                Customer customer = new Customer
                                {
                                    Name = customerData[0],
                                    Email = customerData[1],
                                    Phone = customerData[2]
                                };

                                sale.Customer = customer;


                            }
                        }
                        else
                        {
                            return;
                        }
                        this.sales.Add(sale);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while loading sales from file: {e.Message}");
            }
        }
    }
}



