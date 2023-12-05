using Gallery.Model;
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
                          

                        string encodedEmail = Encryption.EncodeToBase64(txtEmail.Text);
                        if (DatabaseService.IsEmailExists(encodedEmail)) throw new Exception("Email is already exists. Please sign in or re-enter");

                        Random random = new Random();
                        string correctCode = random.Next(10000, 100000).ToString();
                        // Создаем новое окно SignUp
                        VerificationCode verificationCodeWindow = new VerificationCode(txtEmail.Text, passwordBox.Password, correctCode);

                        // Устанавливаем текущее окно (SignInWindow) в качестве владельца для SignUpWindow
                        verificationCodeWindow.Owner = this;

                        // Подписываемся на событие Closed окна SignUpWindow
                        verificationCodeWindow.Closed += (signupSender, signupArgs) =>
                        {
                            // Показываем снова SignInWindow
                            this.Show();
                        };

                        // Открываем окно SignUpWindow
                        verificationCodeWindow.Show();

                        // Скрываем текущее окно SignInWindow
                        this.Hide();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else MessageBox.Show("The passwords don't match. Please re-enter.");
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