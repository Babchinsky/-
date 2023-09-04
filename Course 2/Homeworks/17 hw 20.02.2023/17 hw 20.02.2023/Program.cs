using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void DisplayMessage(string message) => Console.WriteLine(message);



            var card = new CreditCard("Иванов Иван Иванович", new DateTime(2025, 12, 31), 1234, 50000, 10000);
            card.Notify += DisplayMessage;


            Console.WriteLine("Добро пожаловать в банк!");
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Пополнение счёта");
            Console.WriteLine("2 - Вывести со счёта");
            Console.WriteLine("3 - Увеличить кредитный лимит");
            Console.WriteLine("4 - Достижение заданной суммы денег");
            Console.WriteLine("5 - Смена PIN-кода");
            Console.WriteLine("6 - Вывод информации о карте");


            try
            {
                while (true)
                {
                    Console.Write("Выберите действие (для выхода нажмите 'q'): ");
                    var input = Console.ReadLine();

                    if (input == "q")
                        break;

                    switch (input)
                    {
                        case "1":
                            Console.Write("Введите сумму, которую хотите положить на счет: ");
                            var amountToDeposit = int.Parse(Console.ReadLine());
                            card.AddMoney(amountToDeposit);
                            break;
                        case "2":
                            Console.Write("Введите сумму, которую хотите снять со счета: ");
                            var amountToWithdraw = int.Parse(Console.ReadLine());
                            card.SpendMoney(amountToWithdraw);
                            break;
                        case "3":
                            Console.Write("Введите сумму, до которой хотите увеличить кредитный лимит: ");
                            var creditAmount = int.Parse(Console.ReadLine());
                            card.IncreaseCredit(creditAmount);
                            break;
                        case "4":
                            Console.Write("Введите сумму, которую хотите накопить: ");
                            int goalAmount = int.Parse(Console.ReadLine());
                            card.CheckTargetAmount(goalAmount);
                            break;
                        case "5":
                            Console.Write("Введите новый PIN-код: ");
                            var newPin = int.Parse(Console.ReadLine());
                            card.ChangePin(newPin);
                            break;
                        case "6":
                            Console.WriteLine(card);
                            break;
                        default:
                            Console.WriteLine("Неверная команда.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }
            

            Console.WriteLine("Спасибо, что воспользовались нашим банком!");
        }

    }
}
