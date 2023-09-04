using System;
using System.Net.NetworkInformation;

namespace CreditCard
{
    public class CreditCard
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;              // 1.Определение события

        // Поля класса
        private string fullName;
        private DateTime expiryDate;
        private int pin;
        private decimal creditLimit;
        private decimal balance;

        // Конструктор класса
        public CreditCard(string fullName, DateTime expiryDate, int pin, decimal creditLimit, int balance)
        {
            this.fullName = fullName;
            this.expiryDate = expiryDate;
            this.pin = pin;
            this.creditLimit = creditLimit;
            this.balance = balance;
        }

        // Метод для пополнения счёта
        public void AddMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Сумма пополнения должна быть положительной.");
            }

            balance += amount;
            Notify?.Invoke($"На счет поступило: {amount}");
        }

        // Метод для списания средств со счёта
        public void SpendMoney(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма списания должна быть положительной.");
            }

            if(balance < amount)
            {
                Console.WriteLine("Недостаточно средств на счете. Хотите использовать кредитные средства (Y/N): ");
                char answer = Convert.ToChar(Console.ReadLine());

                if (answer == 'y' || answer == 'Y')
                {
                    UseCredit(amount);
                }

                else throw new Exception("Вы отказались от использования кредита. Оплата отклонена");
            }

            else if (balance < amount)
            {
                balance -= amount;
                Notify?.Invoke($"Со счета снято: {amount} без использования кредитных средств");   // 2.Вызов события
            }
        }

        private void UseCredit(decimal amount)
        {
            amount -= balance;
            balance = 0;

            creditLimit -= amount;
            Notify?.Invoke($"Cо счёта списано все средства, а также списано {amount} кредита");   // 2.Вызов события
        }

        public void IncreaseCredit(decimal newLimit)
        {
            creditLimit = newLimit;
            Notify?.Invoke($"Кредитный лимит увеличен до {creditLimit}");   // 2.Вызов события
        }

        // Метод для проверки, достигнута ли заданная сумма денег
        public void CheckTargetAmount(int targetAmount)
        {
            if (balance < targetAmount)
            {
                Notify?.Invoke($"До выполнения цели осталось накопить {targetAmount - balance}");
            }
            else
            {
                Notify?.Invoke($"Цель достигнута");
            }
        }
        
        // Метод для изменения PIN-кода
        public void ChangePin(int newPin)
        {
            Console.Write("Введите предыдущий PIN: ");
            int oldPin = Convert.ToInt32(Console.ReadLine());

            if (oldPin != pin)
            {
                throw new Exception("PIN введён неправильно");
            }

            pin = newPin;
            Notify?.Invoke($"PIN был изменён");
        }

        public override string ToString()
        {
            return $"\n\nФИО владельца: {fullName}\nСрок действия карты: {expiryDate.Month}/{expiryDate.Year}\n" +
                   $"Текущая сумма: {balance} руб.\nКредитный лимит: {creditLimit} руб.\n" +
                   $"PIN-код: {pin}";
        }
    }
}
