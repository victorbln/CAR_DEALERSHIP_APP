using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAR_DEALERSHIP.ModelsLibrary
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Employee,
        Admin
    }

    public class UserManager
    {
        private const string UsersFile = "users.json";
        private List<User> users;

        public UserManager()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (!File.Exists(UsersFile))
            {
                // If the file doesn't exist, create an empty list of users
                users = new List<User>();
                SaveUsers();
                return;
            }

            try
            {
                // Deserialize the list of users from the file
                string json = File.ReadAllText(UsersFile);
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            catch (Exception ex)
            {
                // Handle any errors while reading the file
                Console.WriteLine($"Error loading users: {ex.Message}");
                users = new List<User>();
            }
        }

        private void SaveUsers()
        {
            try
            {
                // Serialize the list of users and save it to the file
                string json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(UsersFile, json);
            }
            catch (Exception ex)
            {
                // Handle any errors while writing to the file
                Console.WriteLine($"Error saving users: {ex.Message}");
            }
        }

        public bool Login(string username, string password, out Role role)
        {
            // Check if the provided username and password match a user in the list
            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                role = user.Role;
                return true;
            }

            role = Role.Employee;
            return false;
        }

        public bool AddUser(User user)
        {
            // Only admins can add new users
            if (user.Role != Role.Admin)
            {
                return false;
            }

            // Check if a user with the same username already exists
            if (users.Any(u => u.Username == user.Username))
            {
                return false;
            }

            users.Add(user);
            SaveUsers();
            return true;
        }
    }
}
