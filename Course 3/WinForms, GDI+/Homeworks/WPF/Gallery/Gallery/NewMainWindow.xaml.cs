using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Gallery
{
    public partial class NewMainWindow : Window
    {
        public NewMainWindow()
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