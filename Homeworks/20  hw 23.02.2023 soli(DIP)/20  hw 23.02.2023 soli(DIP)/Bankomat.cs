using System;

namespace Bankomat
{
    class Bankomat
    {
        UAH uah;
        USD usd;
        EUR eur;

        public Bankomat(Money money)
        {
            if (money is UAH) uah.Amount = money.Amount;
            else if (money is USD) usd.Amount = money.Amount;
            else if (money is EUR) eur.Amount = money.Amount;
        }

        public Bankomat() { }

        //public void Put(Money money, Check check)
        //{
        //    if (money is UAH) uah.Amount += money.Amount;
        //    else if (money is USD) usd.Amount += money.Amount;
        //    else if (money is EUR) eur.Amount += money.Amount;
        //    check.Put(money.Amount);
        //}
        //public void Withdraw(Money money, Check check)
        //{
        //    if (money is UAH) uah.Amount -= money.Amount;
        //    else if (money is USD) usd.Amount -= money.Amount;
        //    else if (money is EUR) eur.Amount -= money.Amount;
        //    check.Withdraw(money.Amount);
        //}

        public void Info()
        {
            Console.WriteLine($"UAH: {uah.Amount}\nUSD: {usd.Amount}\nEUR: {eur.Amount}\n");
        }
    }
}
