using CAR_DEALERSHIP.DataStorageLevel;

using CAR_DEALERSHIP.ModelsLibrary;

namespace CAR_DEALERSHIP
{
    class Program
    {
        static void Main()
        {
            UserManager userManager = new UserManager();

            // Prompt the user to log in
            Role role;
            do
            {
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (userManager.Login(username, password, out role))
                {
                    Console.WriteLine($"Logged in as {role}");
                    break;
                }

                Console.WriteLine("Invalid username or password!");
            } while (true);
            string storageFile = "inventory.json";
            Inventory inventory = new Inventory(storageFile);
            int carId = 0;

            string option;
            do
            {
                Console.WriteLine("A. Add car to inventory");
                Console.WriteLine("I. Show inventory");
                Console.WriteLine("P. Show car properties");
                Console.WriteLine("S. Save inventory");
                Console.WriteLine("D. Sell car");
                //Console.WriteLine("V. View sold cars");
                //Console.WriteLine("M. Show cars sold in current month");
                //Console.WriteLine("N. Show available cars");
                Console.WriteLine("X. Stop program");
                Console.WriteLine("Choose an option: ");


                option = Console.ReadLine();
                switch (option.ToUpper())
                {
                    case "A":
                        Car car = new Car();
                        Console.Write("Make: ");
                        car.Make = Console.ReadLine();
                        Console.Write("Model: ");
                        car.Model = Console.ReadLine();
                        Console.Write("Year: ");
                        car.Year = int.Parse(Console.ReadLine());
                        Console.Write("Price: ");
                        car.Price = decimal.Parse(Console.ReadLine());
                        car.Id = inventory.GetCars().Count + 1;
                        inventory.AddCar(car);
                        break;
                    case "I":
                        List<Car> cars = inventory.GetCars();
                        foreach (Car c in cars)
                        {
                            Console.WriteLine($"{c.Id}. {c.Year} {c.Make} {c.Model}, {c.Price:C}");
                        }
                        break;
                    case "P":
                        Console.Write("Enter car ID: ");
                        carId = int.Parse(Console.ReadLine());
                        ShowCarProperties(inventory, carId);
                        break;
                    case "S":
                        inventory.SaveInventoryToStorage();
                        Console.WriteLine("Inventory saved to file.");
                        break;
                    case "D":
                        Console.Write("Enter car ID: ");
                        carId = int.Parse(Console.ReadLine());
                        inventory.SellCar(carId);
                        break;
                    case "V":
                        Console.WriteLine("View Sold Cars:");
                        // View sold cars
                        inventory.ViewSoldCars();
                        break;
                    case "M":
                        Console.WriteLine("View Cars Sold in Current Month:");
                        // View cars sold in current month
                        inventory.GetSoldCarsThisMonth();
                        break;
                    case "N":
                        Console.WriteLine("View Available Cars:");
                        // View available cars
                        inventory.GetAvailableCars();
                        break;
                    case "X":
                        inventory.SaveInventoryToStorage();
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            } while (option.ToUpper() != "X");

            Console.ReadKey();
        }


        static void ShowCarProperties(Inventory inventory, int carId)
        {
            Car car = inventory.GetCars().FirstOrDefault(c => c.Id == carId);
            if (car != null)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Price: {car.Price:C}");
                Console.WriteLine($"Is Sold: {car.IsSold}");
                if (car.IsSold && car.BuyerName != null)
                {
                    Console.WriteLine($"Buyer Name: {car.BuyerName}");
                    Console.WriteLine($"Sold Date: {car.SoldDate}");
                }
            }
            else
            {
                Console.WriteLine($"Car with ID {carId} not found.");
            }
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