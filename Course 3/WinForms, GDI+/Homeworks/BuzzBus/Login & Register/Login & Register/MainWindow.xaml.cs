using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Security.Cryptography;
using System.Text;

namespace Login___Register
{
    public partial class MainWindow : Window
    {
        private IMongoCollection<BsonDocument> collection;
        public MainWindow()
        {
            InitializeComponent();
            ConnectToDb();
        }
        
        private void ConnectToDb()
        {
            string connectionString = "";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("userbox");
            collection = database.GetCollection<BsonDocument>("users");
        }

        private string ComputeHash(string password, string salt)
        {
            //////////// Логика хеширования пароля с использованием соли
            using (SHA256 sha256 = SHA256.Create())
            {
                // Соль должна быть преобразована в байты
                byte[] saltBytes = Encoding.UTF8.GetBytes(salt);

                // Конкатенация пароля и соли
                byte[] combinedBytes = new byte[saltBytes.Length + password.Length];
                Array.Copy(saltBytes, 0, combinedBytes, 0, saltBytes.Length);
                Array.Copy(Encoding.UTF8.GetBytes(password), 0, combinedBytes, saltBytes.Length, password.Length);

                // Хеширование пароля с использованием SHA-256
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);

                // Преобразование хеша в строку в формате Base64
                string hashedPassword = Convert.ToBase64String(hashBytes);

                return hashedPassword;
            }
        }

        private string GenerateRandomSalt()
        {
            // Generate a random salt using a cryptographic random number generator
            byte[] saltBytes = new byte[16]; // Adjust the size of the salt as needed
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(saltBytes);
            }

            // Convert the salt to a base64-encoded string before returning
            return Convert.ToBase64String(saltBytes);
        }




        private void FindUsernameAndPassword(string username, string password)
        {
            // Искомый username и пароль
            string usernameToSearch = username;
            string passwordToCheck = password; // Пароль в открытом виде

            // Создаем фильтр для поиска по username
            var filter = Builders<BsonDocument>.Filter.Eq("Username", usernameToSearch);

            // Выполняем поиск пользователя по username
            var user = collection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                // Получаем хешированный пароль и соль из базы данных
                string hashedPasswordFromDatabase = user["HashedPassword"].AsString;
                string salt = user["Salt"].AsString;

                // Хешируем введенный пароль с использованием соли
                string hashedPasswordToCheck = ComputeHash(passwordToCheck, salt);

                // Проверяем соответствие хешированных паролей
                if (hashedPasswordFromDatabase == hashedPasswordToCheck)
                {
                    MessageBox.Show("Login successful.");
                }
                else
                {
                    MessageBox.Show("Invalid password.");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }


        private void CheckAndAddUser(string username, string password, string email, string name)
        {
            // Генерация случайной соли для пароля
            string salt = GenerateRandomSalt();

            // Хеширование пароля с использованием соли
            string hashedPassword = ComputeHash(password, salt);

            // Проверяем, что пользователь с таким именем или email не существует
            var filter = Builders<BsonDocument>.Filter.Or(
                Builders<BsonDocument>.Filter.Eq("Username", username),
                Builders<BsonDocument>.Filter.Eq("Email", email)
            );

            var existingUser = collection.Find(filter).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким именем или email уже существует.");
                return;
            }

            // Создаем новый документ пользователя
            var newUserDocument = new BsonDocument
            {
                { "Username", username },
                { "HashedPassword", hashedPassword }, // Захешированный пароль
                { "Salt", salt }, // Соль
                { "Name", name }, // Имя пользователя
                { "Email", email }, // Email пользователя
                { "RegistrationDate", DateTime.Now } // Дата регистрации
                // Можно добавить другие данные пользователя, если необходимо
            };

            // Добавляем нового пользователя в коллекцию
            collection.InsertOne(newUserDocument);

            MessageBox.Show("Регистрация успешно завершена для пользователя с именем: " + username);
        }





        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Foreground == Brushes.Gray)
            {
                textBox.Foreground = Brushes.Black;
                textBox.Text = "";
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Foreground = Brushes.Gray;
                //textBox.Text = textBox.Name.Contains("login") ? "Username" : "Password";
                textBox.Text = textBox.Name;

                switch (textBox.Name)
                {
                    case "registerUsername":
                        textBox.Text = "Username";
                        break;
                    case "registerName":
                        textBox.Text = "Name";
                        break;
                    case "registerEmail":
                        textBox.Text = "Email";
                        break;
                    case "loginUsername":
                        textBox.Text = "Username";
                        break;
                }
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (passwordBox.Foreground == Brushes.Gray)
            {
                passwordBox.Foreground = Brushes.Black;
                passwordBox.Password = "";
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = (PasswordBox)sender;
            if (string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Foreground = Brushes.Gray;
                passwordBox.Password = "Password";
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = loginUsername.Text;
            string password = loginPassword.Password;

            //FindUsername(username);
            FindUsernameAndPassword(username, password);
            //MessageBox.Show("Login clicked. Username: " + username + ", Password: " + password);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = registerUsername.Text;
            string password = registerPassword.Password;
            string email = registerEmail.Text;
            string name = registerName.Text;

            CheckAndAddUser(username, password, email, name);
        }
    }
}
