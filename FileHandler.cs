

namespace CarDealership
{
    public class FileHandler
    {
        private const string InventoryFilePath = "inventory.txt";
        public FileHandler(Inventory inventory)
        {
            ReadInventoryFromFile(inventory);
        }
        public void ReadInventoryFromFile(Inventory inventory)
        {
            try
            {
                string[] lines = File.ReadAllLines(InventoryFilePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    Car car = new Car
                    {
                        Make = data[0],
                        Model = data[1],
                        Year = int.Parse(data[2]),
                        Price = decimal.Parse(data[3]),
                        Color = data[4],
                        Mileage = int.Parse(data[5]),
                        VIN = data[6]
                    };
                    inventory.AddCar(car);

                }
            }
            catch (FileNotFoundException)
            {

            }
            catch (Exception ex)
            {

            }
        }

        public Inventory SaveInventoryToFile(Inventory inventory)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(InventoryFilePath, false))
                {
                    foreach (Car car in inventory.GetAllCars())
                    {
                        string line = $"{car.Make}|{car.Model}|{car.Year}|{car.Price}|{car.Color}|{car.Mileage}|{car.VIN}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception as needed
                Console.WriteLine($"An error occurred while saving the inventory file: {ex.Message}");
            }
            inventory = new Inventory();    
            ReadInventoryFromFile(inventory);
            return inventory;
        }

    }

}
