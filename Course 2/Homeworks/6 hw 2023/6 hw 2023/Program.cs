using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_hw_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_4();
            //Task_5();
            Task_6();
        }
        static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4");
            Website first = new Website();
            first.Init();
            Console.WriteLine(first);
        }

        static void Task_5()
        {
            Console.WriteLine("\n\n\t\t\tTask 5");
            Magazine first = new Magazine();
            first.Init();
            Console.WriteLine(first);
        }
        static void Task_6()
        {
            Console.WriteLine("\n\n\t\t\tTask 6");
            Shop first = new Shop();
            first.Init();
            Console.WriteLine(first);
        }
    }
}
