using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Second
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int password = 8878;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button != null)
                {
                    string buttonText = button.Content?.ToString() ?? "unknown"; // Используем null-условный оператор '?'
                    //MessageBox.Show($"Вы нажали кнопку с текстом: {buttonText}");
                    textBox.Text += buttonText;
                }
            }


        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
        }
        
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text)) 
            {
                if (textBox.Text == password.ToString())
                    MessageBox.Show("Сейф открыт");
                else MessageBox.Show("Пароль не правильный");
            }
        }
    }
}
