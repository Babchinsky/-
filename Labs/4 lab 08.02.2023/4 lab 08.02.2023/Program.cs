using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_lab_08._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard cc1 = new CreditCard();
            cc1.Init();
            Console.WriteLine(cc1);
        }
    }
}
