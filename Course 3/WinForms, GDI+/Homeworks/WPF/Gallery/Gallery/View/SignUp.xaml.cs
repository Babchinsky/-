using System;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gallery
{
    public partial class SignUp : Window
    {
        public SignUp()
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

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordBox.Password) && passwordBox.Password.Length > 0)
                textPassword.Visibility = Visibility.Collapsed;
            else
                textPassword.Visibility = Visibility.Visible;
        }

        private void ConfirmPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(confirmPasswordBox.Password) && confirmPasswordBox.Password.Length > 0)
                textConfirmPassword.Visibility = Visibility.Collapsed;
            else
                textConfirmPassword.Visibility = Visibility.Visible;
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            passwordBox.Focus();
        }
        private void textConfirmPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            confirmPasswordBox.Focus();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && !string.IsNullOrEmpty(passwordBox.Password))
            {
                if (passwordBox.Password == confirmPasswordBox.Password)
                {
                    try
                    {
                        DatabaseService databaseService = new DatabaseService();
                        databaseService.SignUp(txtEmail.Text, passwordBox.Password);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error", ex.Message);
                    }
                    MessageBox.Show("Succesfully Signed Up");
                  
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

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            // Создаем новое окно SignUp
            SignIn signInWindow = new SignIn();

            // Устанавливаем текущее окно (SignInWindow) в качестве владельца для SignUpWindow
            signInWindow.Owner = this;

            // Подписываемся на событие Closed окна SignUpWindow
            signInWindow.Closed += (signupSender, signupArgs) =>
            {
                // Показываем снова SignInWindow
                this.Show();
            };

            // Открываем окно SignUpWindow
            signInWindow.Show();

            // Скрываем текущее окно SignInWindow
            this.Hide();
        }
    }
}