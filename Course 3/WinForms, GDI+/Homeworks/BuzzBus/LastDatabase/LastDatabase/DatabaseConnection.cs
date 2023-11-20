using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace LastDatabase
{
    // Подключение БД
    public class DatabaseConnection
    {
        //firebase connection Settings
        public IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "xiaI2P9t4ZlRREUBmqyYeoeD1e5jDMsNCN2IckGe",
            BasePath = "https://test-e13a9-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        public IFirebaseClient client;
        //Code to warn console if class cannot connect when called.

        public string path = "users/";
        public DatabaseConnection()
        {
            try
            {
                client = new FireSharp.FirebaseClient(fc);
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
