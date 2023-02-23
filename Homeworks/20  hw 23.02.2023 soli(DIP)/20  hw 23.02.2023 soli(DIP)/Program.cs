using System;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money uah= new UAH(100);
            Bankomat bankomat1 = new Bankomat(uah);
            bankomat1.Info();
            //bankomat1.Put(new EUR(100), new SMSCheck());

            //Console.WriteLine();

            //bankomat1.Withdraw(new EUR(50), new EmailCheck());

            //bankomat1.Info();
        }
    }
}
