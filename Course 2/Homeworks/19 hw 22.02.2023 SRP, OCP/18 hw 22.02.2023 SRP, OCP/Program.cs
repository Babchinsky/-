using System;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bankomat bankomat1 = new Bankomat();
            //bankomat1.Put(1000, new SMSCheck());

            //Console.WriteLine();

            //bankomat1.Withdraw(200, new EmailCheck());

            //bankomat1.Info();

            Bankomat balance = new Bankomat(new UAH(100));
            Console.WriteLine(balance);

            balance.Put(new USD(225), new SMSCheck());
            Console.WriteLine(balance);

            balance.Get(new EUR(25), new PhysicalCheck());
            Console.WriteLine(balance);
        }
    }
}
