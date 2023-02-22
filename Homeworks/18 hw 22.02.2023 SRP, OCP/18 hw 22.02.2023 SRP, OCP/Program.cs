using System;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bankomat bankomat1 = new Bankomat();
            bankomat1.Put(1000, new SMSCheck());

            Console.WriteLine();

            bankomat1.Withdraw(200, new EmailCheck());

            bankomat1.Info();
        }
    }
}
