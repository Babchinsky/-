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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Third
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var child in uniformGrid1.Children)
            {
                if (child is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        MessageBox.Show("Вы не заполнили всё текстовые поля");
                        return;
                    }
                }
            }

            CalculateDeterminant();
        }

        private void CalculateDeterminant()
        {
            try
            {
                // Чтение элементов матрицы из TextBox
                double[,] matrix = new double[3, 3]
                {
                    { Convert.ToDouble(Matrix11.Text), Convert.ToDouble(Matrix12.Text), Convert.ToDouble(Matrix13.Text) },
                    { Convert.ToDouble(Matrix21.Text), Convert.ToDouble(Matrix22.Text), Convert.ToDouble(Matrix23.Text) },
                    { Convert.ToDouble(Matrix31.Text), Convert.ToDouble(Matrix32.Text), Convert.ToDouble(Matrix33.Text) }
                };

                // Вычисление определителя
                double determinant = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                                   - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                                   + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);


                // Отображение результата
                resultTextBlock.Text = Math.Round(determinant, 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!IsTextAllowed(e.Text))
            {
                e.Handled = true; // Отменяем ввод, если символ не является цифрой или точкой
            }
        }

        private bool IsTextAllowed(string text)
        {
            // Разрешаем только цифры и точку
            return !string.IsNullOrEmpty(text) && text.All(c => char.IsDigit(c) || c == ',' || c=='-');
        }
    }
}
