using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Inventory
    {
        private List<Car> cars;

        public Inventory()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car car2)
        {
            Car car1= cars.FirstOrDefault(car => car.VIN == car2.VIN);
            if (car1 == null)
            {
                cars.Add(car2);
            }
            else
            {
                MessageBox.Show("Car already in inventory", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DeleteCar(string vin)
        {
            Car car = GetCarByVIN(vin);
            if (car != null)
            {
                cars.Remove(car);
                return true;
            }
            return true;
        }

        public void UpdateCar(string vin, Car updatedCar)
        {
            Car car = GetCarByVIN(vin);
            if (car != null)
            {
                car.Make = updatedCar.Make;
                car.Model = updatedCar.Model;
                car.Year = updatedCar.Year;
                car.Price = updatedCar.Price;
                car.Color = updatedCar.Color;
                car.Mileage = updatedCar.Mileage;
            }
        }

        public Car GetCarByVIN(string vin)
        {
            return cars.FirstOrDefault(car => car.VIN == vin);
            
        }

        public List<Car> GetAllCars()
        {
            return cars;
        }
    }

}
