using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_hw_09._02._2023_overloading_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
        }

        public static void Task_1()
        {
            Console.WriteLine("\n\n\t\t\tTask 1");
            Magazine obj = new Magazine();
            Console.WriteLine(obj + 2250);
        }

        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2");
            Shop obj = new Shop();
            Console.WriteLine(obj + 2250);
        }
    }
}

