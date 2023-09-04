using System;

namespace Bankomat
{
    internal abstract class Check
    {
        public abstract void Put(Currency currency);
        public abstract void Get(Currency currency);
    }

    class SMSCheck :Check
    {
        public override void Put(Currency currency)
        {
            //string nameOfCurrency = string.Empty;
            //if (currency is UAH) nameOfCurrency = "UAH";
            //else if (currency is USD) nameOfCurrency = "USD";
            //else if (currency is EUR) nameOfCurrency = "EUR";
            //else throw new Exception("Неверный ввод валюты");

            Console.WriteLine(DateTime.Now.ToString("g") + " СМС: Ваш счёт пополнен на " + currency.amount + currency.name);
        }
        public override void Get(Currency currency)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " СМС: " + currency.amount + " снято со счёта");
        }
    }

    class EmailCheck : Check
    {
        public override void Put(Currency currency)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Email: Ваш счёт пополнен на " + currency.amount);
        }
        public override void Get(Currency currency)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Email: " + currency.amount + " снято со счёта");
        }
    }

    class PhysicalCheck : Check
    {
        public override void Put(Currency currency)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Физический чек: Ваш счёт пополнен на " + currency.amount);
        }
        public override void Get(Currency currency)
        {
            Console.WriteLine(DateTime.Now.ToString("g") + " Физический чек: " + currency.amount + " снято со счёта");
        }
    }
}
