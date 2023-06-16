using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class UserManager
    {
        private const string UsersFilePath = "users.txt";
        private List<User> users;

        public UserManager()
        {
            users = ReadUsersFromFile();
        }

        public User GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
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
