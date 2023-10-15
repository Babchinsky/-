using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string previousDisplay = string.Empty;
        private string currentDisplay = string.Empty;
        private string currentOperator = string.Empty;
        private double result = 0;

        public string Previous
        {
            get { return previousDisplay; }
            set
            {
                previousDisplay = value;
                PreviousTextBlock.Text = previousDisplay;
            }
        }

        public string Current
        {
            get { return currentDisplay; }
            set
            {
                currentDisplay = value;
                ResultTextBlock.Text = currentDisplay;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CleanEntryButton_Click(object sender, RoutedEventArgs e)
        {
            Current = "0";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Previous = string.Empty;
            Current = "0";
            currentOperator = string.Empty;
            result = 0;
        }

        private void ClearLastDigitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Current.Length == 1) Current = "0";
            else Current = Current.Remove(Current.Length - 1);
        }

        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Current.Contains(","))
                Current += ",";
        }

        private void DigitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Current == "0") Current = string.Empty;
            string digit = (string)((Button)sender).Content;
            Current += digit;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if (Current != string.Empty)
            {
                currentOperator = (string)((Button)sender).Content;
                Previous = $"{Current}{currentOperator}";
                result = double.Parse(Current);
                CleanEntryButton_Click(sender, e);
            }
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            Calculate();
            Previous = string.Empty;
            currentOperator = string.Empty;
        }

        private void Calculate()
        {
            double secondOperand = double.Parse(Current);

            switch (currentOperator)
            {
                case "+":
                    result +=+ secondOperand;
                    break;
                case "-":
                    result -=  secondOperand;
                    break;
                case "*":
                    result *= secondOperand;
                    break;
                case "/":
                    if (secondOperand == 0)
                    {
                        Current = "0";
                        return;
                    }
                    result /= secondOperand;
                    break;
            }

            Current = result.ToString();
        }
    }
}
