using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Shulte
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<int> shulteNumbers;
        private ObservableCollection<int> sortedCollection;
        private int currentIndex;

        public ObservableCollection<int> ShulteNumbers
        {
            get { return shulteNumbers; }
            set { shulteNumbers = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            ShulteNumbers = new ObservableCollection<int>(GenerateUniqueRandomValues(16, 0, 100));
            // Используем LINQ для сортировки значений по возрастанию
            var sortedValues = ShulteNumbers.OrderBy(item => item);

            // Создаем новую ObservableCollection<int> с отсортированными значениями
            sortedCollection = new ObservableCollection<int>(sortedValues);

            InitializeShulteTable();
        }

        private void InitializeShulteTable()
        {
            

            currentIndex = 0;
            DataContext = this;

            
        }

        private void ShulteButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if ((int)button.Content == sortedCollection[currentIndex])
                {
                    button.IsEnabled = false; // Делаем кнопку неактивной
                    if (currentIndex == 15)
                    {
                        MessageBox.Show("You completed the Shulte Table!");
                        InitializeShulteTable();
                    }
                    else
                    {
                        currentIndex++;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong number! Start over.");
                    InitializeShulteTable();
                }
            }
        }

        private List<int> GenerateUniqueRandomValues(int count, int minValue, int maxValue)
        {
            if (count > (maxValue - minValue + 1))
            {
                MessageBox.Show("Cannot generate unique values. Range is smaller than the count.");
                return new List<int>();
            }

            List<int> values = Enumerable.Range(minValue, maxValue - minValue + 1).OrderBy(x => Guid.NewGuid()).ToList();

            return values.Take(count).ToList();
        }
    }
}
