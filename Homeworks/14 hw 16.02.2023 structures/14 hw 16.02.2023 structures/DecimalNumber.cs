using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_hw_16._02._2023_structures
{
    public struct DecimalNumber
    {
        private int number;

        public DecimalNumber(int number)
        {
            this.number = number;
        }

        public string ToBinary()
        {
            return Convert.ToString(number, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(number, 8);
        }

        public string ToHexadecimal()
        {
            return Convert.ToString(number, 16);
        }
        public override string ToString()
        {
            return number.ToString();
        }
    }
}
