using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_hw_20._02._2023_simple_example_of_events
{
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;              // 1.Определение события


        public int Sum { get; private set; }


        public Account() :this(100){ } 
        public Account(int sum) => Sum = sum;

        public void Put(int sum)
        {
            Sum += sum;
            //if (Notify != null) Notify($"На счет поступило: {sum}");
            Notify?.Invoke($"На счет поступило: {sum}");   // 2.Вызов события 
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Со счета снято: {sum}");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
            }
        }
    }
}
