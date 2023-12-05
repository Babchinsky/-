using Gallery.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gallery
{
    public partial class VerificationCode : Window
    {
        private string Email {  get; set; }
        private string PasswordInput { get; set; }
        private string Code {  get; set; }

        public VerificationCode(string email, string password, string correctCode)
        {
            Email = email;
            PasswordInput = password;
            Code = correctCode;
            InitializeComponent();

            EmailVerification emailVerification = new EmailVerification();
            emailVerification.SendMessage(Code, Email);
        }
        private void CodeBox_TextChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(codeBox.Password) && codeBox.Password.Length > 0)
                textCode.Visibility = Visibility.Collapsed;
            else
                textCode.Visibility = Visibility.Visible;
        }
        private void textCode_MouseDown(object sender, MouseButtonEventArgs e)
        {
            codeBox.Focus();
        }
        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(codeBox.Password))
            {
                if (codeBox.Password == Code)
                {
                    try
                    {
                        DatabaseService databaseService = new DatabaseService();
                        databaseService.SignUp(Email, PasswordInput);
                        MessageBox.Show("Succesfully Signed Up");
                    }
                    catch (System.Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong code. Please re-enter");
                }
            }
        }
    }
}