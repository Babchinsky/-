using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_hw_20._02._2023_simple_example_of_events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void DisplayMessage(string message) => Console.WriteLine(message);

            Account account = new Account(100);
            account.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
            account.Put(20);    // добавляем на счет 20
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(70);   // пытаемся снять со счета 70
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(180);  // пытаемся снять со счета 180
            Console.WriteLine($"Сумма на счете: {account.Sum}");

        }
    }
}
