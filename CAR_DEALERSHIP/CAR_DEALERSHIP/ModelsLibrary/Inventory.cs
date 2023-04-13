
using CAR_DEALERSHIP.DataStorageLevel;

namespace CAR_DEALERSHIP.ModelsLibrary
{
    public class Inventory
    {
        private List<Car> cars;
        private CarsInventoryStorageManager storageManager;

        public Inventory(string storageFile)
        {
            cars = new List<Car>();
            storageManager = new CarsInventoryStorageManager(storageFile);
            LoadInventoryFromStorage();
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public List<Car> ViewSoldCars()
        {
            return cars.Where(c => c.IsSold).ToList();
        }


        public List<Car> GetCars()
        {
            return cars;
        }
        public List<Car> GetAvailableCars()
        {
            return cars.Where(c => !c.IsSold).ToList();
        }
        public List<Car> GetSoldCarsThisMonth()
        {
            DateTime now = DateTime.Now;
            return cars.Where(c => c.IsSold && c.SoldDate != null && c.SoldDate.Value.Year == now.Year && c.SoldDate.Value.Month == now.Month).ToList();
        }

        public void SellCar(int carId)
        {
            Car car = cars.FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                car.IsSold = true;
                car.SoldDate = DateTime.Now;
            }
        }

        public void SaveInventoryToStorage()
        {
            storageManager.SaveInventory(cars);
        }

        private void LoadInventoryFromStorage()
        {
            List<Car> loadedCars = storageManager.LoadInventory();
            if (loadedCars != null)
            {
                cars = loadedCars;
            }
        }
    }


}
