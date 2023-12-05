using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gallery
{
    public partial class SignIn : Window
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void PasswordBox_TextChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordBox.Password) && passwordBox.Password.Length > 0)
                textPassword.Visibility = Visibility.Collapsed;
            else
                textPassword.Visibility = Visibility.Visible;
        }
        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox.Focus();
        }
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            {
                try
                {
                    if (!Model.Validation.IsValidEmail(txtEmail.Text))
                    {
                        throw new Exception("Email does not validate");
                    }
                    if (!Model.Validation.IsValidPassword(passwordBox.Password))
                    {
                        throw new Exception("Password must contain a minimum of 8 characters including numbers, upper and lower case letters");
                    }

                    DatabaseService databaseService = new DatabaseService();
                    if (databaseService.SignIn(txtEmail.Text, passwordBox.Password))
                    {
                        MessageBox.Show("Succesfully Signed In");
                    }
                    
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else MessageBox.Show("Inputs are empty. Please write email and password");
        }
        private void txtEmail_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && txtEmail.Text.Length > 0)
                textEmail.Visibility = Visibility.Collapsed;
            else
                textEmail.Visibility = Visibility.Visible;
        }
        private void textEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtEmail.Focus();
        }
        private void SignUpClick(object sender, RoutedEventArgs e)
        {
            // Создаем новое окно SignUp
            SignUp signUpWindow = new SignUp();

            // Устанавливаем текущее окно (SignInWindow) в качестве владельца для SignUpWindow
            signUpWindow.Owner = this;

            // Подписываемся на событие Closed окна SignUpWindow
            signUpWindow.Closed += (signupSender, signupArgs) =>
            {
                // Показываем снова SignInWindow
                this.Show();
            };

            // Открываем окно SignUpWindow
            signUpWindow.Show();

            // Скрываем текущее окно SignInWindow
            this.Hide();
        }
    }
}