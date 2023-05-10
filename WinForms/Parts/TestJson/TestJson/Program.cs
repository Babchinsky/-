using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TestJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса JsonFileManager с указанием пути к файлу JSON
            JsonFileManager jsonManager = new JsonFileManager("users.json");

            // Чтение содержимого файла JSON
            //List<User> users = jsonManager.ReadFile();

            // Добавление нового пользователя
            //User newUser = new User { Email = "example@example.com", Password = "password123" };
            //jsonManager.AddUser(newUser);

            // Проверка наличия адреса электронной почты в файле JSON
            bool emailExists = jsonManager.IsEmailExists("example@example.com");
            if (emailExists)
            {
                Console.WriteLine("Адрес электронной почты существует в файле JSON.");
            }
            else
            {
                Console.WriteLine("Адрес электронной почты не найден в файле JSON.");
            }

        }
    }

    
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class JsonFileManager
    {
        private string filePath;

        public JsonFileManager(string filePath)
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
                if (user == checkedUser)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
