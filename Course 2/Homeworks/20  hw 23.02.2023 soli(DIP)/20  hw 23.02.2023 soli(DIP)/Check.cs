using System;


namespace Bankomat
{
    internal abstract class Check
    {
        public abstract void Put(decimal amount);
        public abstract void Withdraw(decimal amount);
    }

    class SMSCheck : Check
    {
        public override void Put(decimal amount)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " СМС: Ваш счёт пополнен на " + amount);
        }
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " СМС: " + amount + " снято со счёта");
        }
    }

    class EmailCheck : Check
    {
        public override void Put(decimal amount)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Email: Ваш счёт пополнен на " + amount);
        }
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Email: " + amount + " снято со счёта");
        }
    }

    class PhysicalCheck : Check
    { 
        public override void Put(decimal amount)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Физический чек: Ваш счёт пополнен на " + amount);
        }
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Физический чек: " + amount + " снято со счёта");
        }
    }
}
