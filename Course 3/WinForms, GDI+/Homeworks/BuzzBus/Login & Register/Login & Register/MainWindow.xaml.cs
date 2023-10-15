using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System;
using MongoDB.Driver;
using MongoDB.Bson;



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
            string connectionString = "mongodb+srv://babchinskyprog:Pass123@buzzbuscluster.pymxgjf.mongodb.net/userbox?retryWrites=true&w=majority";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("userbox");
            collection = database.GetCollection<BsonDocument>("users");
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
                // Получаем пароль из базы данных
                string passwordFromDatabase = user["Password"].AsString;

                // Проверяем соответствие паролей
                if (passwordFromDatabase == passwordToCheck)
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

        private void CheckAndAddUser(string username, string password)
        {
            // Данные нового пользователя
            string newUsername = username;
            string newPassword = password; // Пароль в открытом виде

            // Проверяем, что пользователь с таким именем не существует
            var existingUserFilter = Builders<BsonDocument>.Filter.Eq("Username", newUsername);
            var existingUser = collection.Find(existingUserFilter).FirstOrDefault();
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким именем уже существует.");
                return;
            }

            // Создаем новый документ пользователя
            var newUserDocument = new BsonDocument
        {
            { "Username", newUsername },
            { "Password", newPassword }
            // Можно добавить другие данные пользователя, например, email, имя и т.д.
        };

            // Добавляем нового пользователя в коллекцию
            collection.InsertOne(newUserDocument);

            MessageBox.Show("Регистрация успешно завершена для пользователя с именем: " + newUsername);
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
                textBox.Text = textBox.Name.Contains("login") ? "Username" : "Password";
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

            CheckAndAddUser(username, password);
            //MessageBox.Show("Register clicked. Username: " + username + ", Password: " + password);
        }
    }
}
