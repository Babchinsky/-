using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal abstract class Money
    {
        public decimal Amount { get; set; }
        public string Type { get; protected set; }
        public double Value { get; protected set; }

        public Money() {Amount= 0; Type = " "; }
        public Money(int amount) : this() { Amount = amount; Value = 0; }

        public static Money operator + (Money obj, int number)
        {
            obj.Amount = obj.Amount + number;
            return obj;
        }
        public static Money operator - (Money obj, int number)
        {
            obj.Amount = obj.Amount - number;
            return obj;
        }
    }


    internal class UAH : Money
    {
        public UAH()
        {
            Amount = 0;
            Value = 36.8;
            Type = "Гривна";
        }
        public UAH(decimal amount) : this() { Amount = amount; }
    }
    internal class USD : Money
    {
        public USD()
        {
            Amount = 0;
            Value = 1;
            Type = "Доллар";
        }
        public USD(decimal amount) : this() { Amount = amount; }
    }
    internal class EUR : Money
    {
        public EUR()
        {
            Amount = 0;
            Value = 0.94;
            Type = "Евро";
        }
        public EUR(decimal amount) : this() { Amount = amount; }
    }
}
