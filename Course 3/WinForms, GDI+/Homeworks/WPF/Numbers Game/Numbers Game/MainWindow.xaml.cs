using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Numbers_Game
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<int> listForBtns;
        private ObservableCollection<int> sortedListForBtns;
        private int currentIndex; // индекс для того, чтобы отслеживать, какое число

        private DispatcherTimer timer;
        private int remainingMinutes = 1; // начальное количество минут
        private int remainingSeconds = 0;  // начальное количество секунд


        #region Numeric UpDown
        public int Value
        {
            get { return int.Parse(numericTextBox.Text); }
            set { numericTextBox.Text = value.ToString(); }
        }

        private void IncreaseValue(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numericTextBox.Text, out int currentValue))
            {
                Value = currentValue + 1;


                if (Value > 59)
                {
                    remainingMinutes++;
                    remainingSeconds = 0;
                }
                else remainingSeconds++;

            }
        }

        private void DecreaseValue(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(numericTextBox.Text, out int currentValue))
            {
                Value = Math.Max(0, currentValue - 1);

                if (Value < 0)
                {
                    remainingMinutes--;
                    remainingSeconds = 59;
                }
                else remainingSeconds--;
            }
        }
        #endregion


        public ObservableCollection<int> ListForBtns
        {
            get { return listForBtns; }
            set { listForBtns = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            CreateRandomList();
        }



        private void CreateRandomList()
        {
            ListForBtns = new ObservableCollection<int>(GenerateUniqueRandomValues(16, 0, 100));

            // Используем LINQ для сортировки значений по возрастанию
            var sortedValues = ListForBtns.OrderBy(item => item);

            // Создаем новую ObservableCollection<int> с отсортированными значениями
            sortedListForBtns = new ObservableCollection<int>(sortedValues);
            currentIndex = 0;

            DrawInterface();
        }

        private void DrawInterface()
        {
            int i = 0;
            foreach (Button button in uniformGrid.Children)
            {
                button.Content = listForBtns[i++];
            }
            progressBar.Value = 0;
        }


        #region Timer
        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1); // устанавливаем интервал 1 секунда
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
            }
            else if (remainingMinutes > 0)
            {
                remainingMinutes--;
                remainingSeconds = 59;
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time is over.");
            }

            // Обновляем заголовок окна
            UpdateWindowTitle();
        }

        private void UpdateWindowTitle()
        {
            // Обновляем заголовок окна
            this.Title = $"Таймер ({remainingMinutes:D2}:{remainingSeconds:D2})";
        }
        #endregion Timer


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if ((int)button.Content == sortedListForBtns[currentIndex])
                {
                    button.IsEnabled = false; // Делаем кнопку неактивной
                    listBox.Items.Add(button.Content);
                    // Получаем последний элемент в коллекции
                    var lastItem = listBox.Items[listBox.Items.Count - 1];

                    // Прокручиваем ListBox к последнему элементу
                    listBox.ScrollIntoView(lastItem);
                    progressBar.Value++;

                    if (currentIndex == 15)
                    {
                        MessageBox.Show("You completed the Shulte Table!");
                        CreateRandomList();
                    }
                    else
                    {
                        currentIndex++;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong number! Start over.");
                    DrawInterface();
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

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            remainingMinutes = Value / 60;  // Полные минуты
            remainingSeconds = Value % 60;  // Остаток секунд
            CreateRandomList();  
        }
    }
}
