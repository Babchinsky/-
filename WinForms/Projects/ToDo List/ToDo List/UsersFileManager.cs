using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace ToDo_List
{
    public class UsersFileManager
    {
        private string filePath;

        public UsersFileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public List<User> ReadFile()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
                return users;
            }
            else
            {
                return new List<User>();
            }
        }

        public void AddUser(User user)
        {
            List<User> users = ReadFile();

            users.Add(user);
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
         
        // Недавно добавил
        public void RemoveUser(User user)
        {
            List<User> users = ReadFile();
            users.Remove(user);

            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        
        public bool IsEmailExists(string checkedEmail)
        {
            List<User> users = ReadFile();
            foreach (User user in users)
            {
                if (user.Email == checkedEmail)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsUserExists(User checkedUser)
        {
            List<User> users = ReadFile();
            foreach (User user in users)
            {
                if (user.Email == checkedUser.Email && user.Password == checkedUser.Password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

