using Microsoft.VisualBasic.ApplicationServices;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class AuthenticationManager
    {
        private const string UsersFilePath = "users.txt";
        private List<User> users;

        public AuthenticationManager()
        {
            users = ReadUsersFromFile();
        }

        public bool Login(string username, string password)
        {
            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                // User found, perform login actions
                return true;
            }

            return false;
        }

        public void Logout()
        {
            // Perform logout actions
        }

        private List<User> ReadUsersFromFile()
        {
            List<User> userList = new List<User>();

            try
            {
                string[] lines = File.ReadAllLines(UsersFilePath);

                foreach (string line in lines)
                {
                    string[] data = line.Split('|');

                    User user = new User
                    {
                        Username = data[0],
                        Password = data[1],
                        Role = (UserRole)Enum.Parse(typeof(UserRole), data[2])
                    };

                    userList.Add(user);
                }
            }
            catch (FileNotFoundException)
            {
                // File not found, handle the exception as needed
            }
            catch (Exception ex)
            {
                // Other exceptions occurred, handle them as needed
                Console.WriteLine($"An error occurred while reading the user file: {ex.Message}");
            }

            return userList;
        }
    }

}
