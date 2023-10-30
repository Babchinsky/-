using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Realms;
using System.Security.Cryptography;
using System.Text;
using Realms.Sync;

namespace Login___Register
{
    public partial class MainWindow : Window
    {
        private Realm _realm;

        public MainWindow()
        {
            InitializeComponent();
            ConnectToRealm();
        }

        private void ConnectToRealm()
        {
            var appId = "your-app-id"; // Замените на ваш фактический Realm App Id

            // Инициализация подключения к MongoDB Realm
            var appConfig = new AppConfiguration(appId)
            {
                // Дополнительные параметры, если необходимо.
            };

            var user = App.Create(appConfig).GetCurrentUser();
            if (user == null)
            {
                MessageBox.Show("Не удалось аутентифицироваться в MongoDB Realm.");
                Close();
            }

            _realm = user.GetRealm("todo"); // Замените "myrealm" на имя вашей Realm базы данных
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
            string usernameToSearch = username;

            var user = _realm.Find<User>(usernameToSearch);

            if (user != null)
            {
                string salt = user.Salt;
                string hashedPasswordFromDatabase = user.HashedPassword;

                string hashedPasswordToCheck = ComputeHash(password, salt);

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
            var existingUser = _realm.Find<User>(u => u.Username == username || u.Email == email).FirstOrDefault();

            if (existingUser != null)
            {
                MessageBox.Show("User with the same username or email already exists.");
                return;
            }

            string salt = GenerateRandomSalt();
            string hashedPassword = ComputeHash(password, salt);

            _realm.Write(() =>
            {
                _realm.Add(new User
                {
                    Username = username,
                    HashedPassword = hashedPassword,
                    Salt = salt,
                    Name = name,
                    Email = email,
                    RegistrationDate = DateTimeOffset.Now
                });
            });

            MessageBox.Show("Registration successful for the user with username: " + username);
        }

        // Остальной код остается без изменений
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
