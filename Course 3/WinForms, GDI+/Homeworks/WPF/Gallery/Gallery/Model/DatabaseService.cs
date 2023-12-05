using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Controls;
using System.Windows;
using System.Xml.Linq;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace Gallery
{
    // Подключение БД
    public class DatabaseConnection
    {
        //firebase connection Settings
        public IFirebaseConfig fc = new FirebaseConfig()
        {
            AuthSecret = "kosZk8jvQeDSXzFZ6x9oZAM0ijf85qEpqC6rzH21",
            BasePath = "https://gallerywpf-91caa-default-rtdb.europe-west1.firebasedatabase.app/"
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
            catch (Exception ex)
            {
                throw new Exception($"Error Connecting to Database {ex.Message}");
            }
        }
    }

    public class DatabaseService
    {
        DatabaseConnection dbConnection;
        //private static DatabaseUser me { get; set; }
        public DatabaseService()
        {
            dbConnection = new();
        }

        public void AddUser(DatabaseUser user)
        {
            try
            {
                dbConnection.client.Set(dbConnection.path + user.Email, user);
            }
            catch (Exception)
            {

                throw new Exception("Ошибка в методе AddUser");
            }
        }
        public void UpdateUser(DatabaseUser user)
        {
            FirebaseResponse response = dbConnection.client.Get(dbConnection.path + user.Email);

            if (response.Body == "null")
            {
                throw new Exception("Can't find user in database. Error in UpdateUser");
            }
            else
            {
                dbConnection.client.Update(dbConnection.path + user.Email, user);
            }
        }
        public DatabaseUser GetUser(string encodedEmail)
        {
            FirebaseResponse response = dbConnection.client.Get(dbConnection.path + encodedEmail);
            if (response.Body == "null") throw new Exception("Can't find user in database");

            try
            {
                DatabaseUser user = JsonConvert.DeserializeObject<DatabaseUser>(response.Body);
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error with serialization in GetUser {ex.Message}");
            }
        }

        public void SignUp(string email, string password)
        {
            try
            {
                DatabaseUser user = new DatabaseUser();

                string encodedEmail = Encryption.EncodeToBase64(email);
                user.Email = encodedEmail;

                string salt = Encryption.GenerateSalt();
                user.Salt = salt;

                string hashedPassword = Encryption.HashPassword(password, salt);
                user.Password = hashedPassword;

                AddUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool SignIn(string email, string passwordInput)
        {
            try
            {
                string encodedEmail = Encryption.EncodeToBase64(email);
                DatabaseUser user = GetUser(encodedEmail);

                string decodedEmail = Encryption.DecodeFromBase64(user.Email);

                bool isValidPassword = Encryption.VerifyPassword(passwordInput, user.Password, user.Salt);

                if (isValidPassword == true && decodedEmail == email) return true;
                else throw new Exception("Invalid Email or Password");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
