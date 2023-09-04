using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Bankomat
    {
        UAH uah;
        USD usd;
        EUR eur;

        public Bankomat()
        {
            uah = new UAH(0);
            usd = new USD(0);
            eur = new EUR(0);
        }
        public Bankomat(Currency currency) : this()
        {
            if (currency is UAH) uah.amount = currency.amount;
            else if (currency is USD) usd.amount = currency.amount;
            else if (currency is EUR) eur.amount = currency.amount;
        }

        public void Put(Currency currency, Check check)
        {
            if (currency is UAH) uah.amount += currency.amount;
            else if (currency is USD) usd.amount += currency.amount;
            else if (currency is EUR) eur.amount += currency.amount;
            else throw new Exception("Некоректный ввод валюты");
            check.Put(currency);
        }

        public void Get(Currency currency, Check check)
        {
            if (currency is UAH)
            {
                if (uah.amount < currency.amount) Console.WriteLine("Недостаточное количество UAH для снятия");
                else
                {
                    uah.amount -= currency.amount;
                    check.Get(currency);
                }
            }

            if (currency is USD)
            {
                if (usd.amount < currency.amount) Console.WriteLine("Недостаточное количество USD для снятия");
                else
                {
                    usd.amount -= currency.amount;
                    check.Get(currency);
                }
            }

            if (currency is EUR)
            {
                if (eur.amount < currency.amount) Console.WriteLine("Недостаточное количество EUR для снятия");
                else
                {
                    eur.amount -= currency.amount;
                    check.Get(currency);
                }
            }
        }

        public override string ToString()
        {
            return $"UAH: {uah.amount}\nUSD: {usd.amount}\nEUR: {eur.amount}\n";
        }
    }
}
