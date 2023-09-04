////using System;
////using System.Collections.Generic;
////using System.IO;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;
////using Newtonsoft.Json;

////namespace Test_of_UsersData
////{
////    internal class Program
////    {
////        public void Main()
////        {
////            string filePath = "users.json"; // Путь к JSON-файлу

////            // Создаем экземпляр JsonFileManager с указанием пути к файлу
////            JsonFileManager jsonFileManager = new JsonFileManager(filePath);

////            List<User> users = jsonFileManager.GetUsers();

////            Console.WriteLine(users.Count);

////        }
////    }

////    public class Event
////    {
////        public string Name { get; set; }
////        public DateTime Date { get; set; }

////        public Event() { }
////        public Event(string name, DateTime date)
////        {
////            Name = name;
////            Date = date;
////        }
////    }
////    public class User 
////    { 
////        public string Email { get; set; }
////        public string Password { get; set; }
////        public List<Event> Events { get; set; }
////        public User() { }
////        public User(string email, string password, List<Event> events)
////        {
////            Email = email;
////            Password = password;
////            this.Events = events;
////        }
////    }



////    public class JsonFileManager
////    {
////        private string filePath;

////        public JsonFileManager(string filePath)
////        {
////            this.filePath = filePath;
////        }

////        public List<User> GetUsers()
////        {
////            if (File.Exists(filePath))
////            {
////                string json = File.ReadAllText(filePath);
////                List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
////                return users;
////            }
////            else
////            {
////                return new List<User>();
////            }
////        }

////        public void AddUser(User user)
////        {
////            List<User> users = GetUsers();

////            users.Add(user);
////            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
////            File.WriteAllText(filePath, json);
////        }

////        // Недавно добавил
////        public void RemoveUser(User user)
////        {
////            List<User> users = GetUsers();
////            users.Remove(user);

////            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
////            File.WriteAllText(filePath, json);
////        }


////        public bool IsEmailExists(string checkedEmail)
////        {
////            List<User> users = GetUsers();
////            foreach (User user in users)
////            {
////                if (user.Email == checkedEmail)
////                {
////                    return true;
////                }
////            }
////            return false;
////        }

////        public bool IsUserExists(User checkedUser)
////        {
////            List<User> users = GetUsers();
////            foreach (User user in users)
////            {
////                if (user.Email == checkedUser.Email && user.Password == checkedUser.Password)
////                {
////                    return true;
////                }
////            }
////            return false;
////        }
////    }
////}







////using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text.Json;
//using System.Text.Json.Serialization;
//using System.Xml.Linq;

//namespace MyNamespace
//{
//    class Program1
//    {
//        public static void Output(List<User> users)
//        {
//            foreach (var user in users)
//            {
//                Console.WriteLine($"Email: {user.email}\n" +
//                    $"Password: {user.password}\nEvents:");

//                foreach (var evnt in user.events)
//                {
//                    Console.WriteLine(evnt.date + " " + evnt.name);
//                }
//                Console.WriteLine();
//            }
//        }


//        static void Main(string[] args)
//        {
//            UserJsonFileHandler fileHandler = new UserJsonFileHandler("users.json");

//            // Чтение пользователей из JSON-файла
//            List<User> users = fileHandler.ReadUsersFromJsonFile();

//            //if (fileHandler.ReadUsersFromJsonFile() != null)
//            //{
//            //    users = 
//            //}
//            //else users = new List<User>();



//            //Output(users);

//            #region Добавить пользователя

//            User userToAdd = new User("example2", "456", null);
//            users.Add(userToAdd);
            
//            #endregion

//            #region Добавить конкретное событие конкретному пользователю
//            //Event eventToAdd = new Event("2024-05-24", "Test");
//            //for (int i = 0; i < users.Count; i++)
//            //{
//            //    if (users[i].email == "example")
//            //    {
//            //        users[i].events.Add(eventToAdd);
//            //    }
//            //}
//            #endregion


//            #region Удаление конректного пользователя
//            //users.RemoveAll(user => user.email == "user2@example.com"); // удаление пользователя из users
//            #endregion

//            #region Удаление конкретного события у конкретного пользователя

//            //Event eventToRemove = new Event("2024-05-24", "Test");
//            //string emailInWhichRemovedEvent = "user2@example.com";

//            //for (int i = 0; i < users.Count; i++)
//            //{
//            //    if (users[i].email == emailInWhichRemovedEvent)
//            //    {
//            //        users[i].events.Remove(eventToRemove);
//            //    }
//            //}


//            #endregion

//            //Output(users);

//            fileHandler.WriteUsersToJsonFile(users);





//            //Добавление новых пользователей в список
//            //users.Add(new User
//            //{
//            //    email = "newuser@example.com",
//            //    password = "newpassword",
//            //    events = new List<Event>
//            //    {
//            //        new Event {date = "2024-05-19", name = "Event 5" },
//            //        new Event {date = "2024-05-20", name = "Event 6" }
//            //    }
//            //});

//        }
//    }

//    public class Event
//    {
//        public string date { get; set; }
//        public string name { get; set; }

//        public Event() { }
//        public Event(string date, string name)
//        {
//            this.date = date;
//            this.name = name;
//        }
//    }
//    public class User
//    {
//        public string email { get; set; }
//        public string password { get; set; }
//        public List<Event> events { get; set; }

//        public User() { }
//        public User(string email, string password, List<Event> events)
//        {
//            this.email = email;
//            this.password = password;
//            this.events = events;
//        }
//    }

//    public class UserJsonFileHandler
//    {
//        private readonly string _filePath;

//        public UserJsonFileHandler(string filePath)
//        {
//            _filePath = filePath;
//        }

//        public List<User> ReadUsersFromJsonFile()
//        {
//            List<User> users = new List<User>();

//            string json = File.ReadAllText(_filePath);
//            users = JsonSerializer.Deserialize<List<User>>(json);
            
//            //try
//            //{
                
//            //}
//            //catch (FileNotFoundException)
//            //{
//            //    Console.WriteLine($"JSON file {_filePath} not found.");
//            //}
//            //catch (JsonException)
//            //{
//            //    Console.WriteLine($"Error deserializing JSON file {_filePath}.");
//            //}

//            return users;
//        }

//        public void WriteUsersToJsonFile(List<User> users)
//        {
//            try
//            {
//                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
//                File.WriteAllText(_filePath, json);
//            }
//            catch (Exception)
//            {
//                Console.WriteLine($"Error writing JSON file {_filePath}.");
//            }
//        }
//    }
//}

