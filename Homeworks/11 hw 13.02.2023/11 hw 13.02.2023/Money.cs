using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_hw_13._02._2023
{
    internal class Money
    {
        public int Whole { get; set; }
        public int Pennies { get; set; }

        public Money() :this(0,0){ }
        public Money(int whole, int pennies)
        {
            Whole = whole;
            Pennies = pennies;
        }

        public double Sum()
        {
            return Whole + 0.01 * Pennies;
        }
    }
}
