using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using nsATM;
//using nsMoney;
using nsPrint;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            IPrint print;
            IMoney money;

            int chooseCurrency;
            int amount;
            int choosePrint;
            Console.WriteLine("Choose currency (UAH - 1, USD - 2, EUR - 3) : ");
            chooseCurrency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount : ");
            amount = Convert.ToInt32(Console.ReadLine());

            switch (chooseCurrency)
            {
                case 1: money = (new UAH((uint)amount)); break;
                case 2: money = (new USD((uint)amount)); break;
                case 3: money = (new EUR((uint)amount)); break;
                default: throw new Exception("Unexpected currency");
            }

            Console.WriteLine("Enter how to print (Output on screen - 1, Send SMS - 2, Print on paper - 3) : ");
            choosePrint = Convert.ToInt32(Console.ReadLine());

            switch (choosePrint)
            {
                case 1: print = new Show(); break;
                case 2: print = new SMS(); break;
                case 3: print = new PrintCheck(); break;
                default: throw new Exception("Unexpected print");
            }

            Console.WriteLine(atm.GetCheck(money, print));
        }
    }
}