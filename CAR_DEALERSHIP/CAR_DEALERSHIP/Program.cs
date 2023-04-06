using CAR_DEALERSHIP.DataStorageLevel;

using CAR_DEALERSHIP.ModelsLibrary;

namespace CAR_DEALERSHIP
{
    class Program
    {
        static void Main()

        {
            Car car = new();
            //string storageFile = ConfigurationManager.AppSettings["NumeFisier"];
            CarsInventoryManager inventoryManager = new CarsInventoryManager("asd");
            int nrCars = 0;
            int idCar = 0;

            inventoryManager.GetCars(out nrCars);
            string option;
            do
            {
            
                Console.WriteLine("A. Add car to inventory");
                Console.WriteLine("I. Show inventory");
                Console.WriteLine("P. Show car properties");
                Console.WriteLine("F. Show last month sales");
                Console.WriteLine("S. Save inventory");
                Console.WriteLine("D. Sell car");
                Console.WriteLine("X. Stop program");
                Console.WriteLine("Choose an option: ");
           
                option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "A":
                        car = GetCarFromKeyboard();

                        break;
                    case "I":
                        ShowInventory();

                        break;
                    case "P":
                        ShowCarProperties(idCar);

                        break;
                    case "F":

                        ShowLastMonthSales();

                        break;
                    case "S":
                        
                        car.Id = nrCars + 1;
                        
                        inventoryManager.AddCars(car);

                        nrCars = nrCars + 1;

                        break;
                    case "D":
                        sellCar(idCar);

                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } while (option.ToUpper() != "X");

            Console.ReadKey();
        }

        private static void sellCar(int idCar)
        {
            throw new NotImplementedException();
        }

        private static void ShowLastMonthSales()
        {
            throw new NotImplementedException();
        }

        private static void ShowCarProperties(int idCar)
        {
            throw new NotImplementedException();
        }

        private static void ShowInventory()
        {
            throw new NotImplementedException();
        }

        private static Car GetCarFromKeyboard()
        {
            throw new NotImplementedException();
        }
    }
}