using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_hw_13._02._2023
{
    internal class Program
    {
        static void Main()
        {
            //Task_1();
            //Task_2();
            //Task_3();
            Task_4();
        }
        public static void Task_1()
        {
            Console.WriteLine("\n\n\t\t\tTask 1\n");
            Product p1 = new Product(new Money(100,30), 3);
            Console.WriteLine(p1);
            p1 = p1 + new Money(100,30);
            Console.WriteLine(p1);
        }
        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2\n");
            Device ptr = null;
            ptr = new Kettle("T1", "Good");
            ptr.Sound();
            ptr.Show();
            ptr.Desc();
        }
        public static void Task_3()
        {
            Console.WriteLine("\n\n\t\t\tTask 3\n");
            Console.WriteLine("\n\n\t\t\tTask 2\n");
            MusicalInstrument ptr = null;
            ptr = new Violin("T1", "Good");
            ptr.Sound();
            ptr.Show();
            ptr.Desc();
            ptr.History();
        }
        public static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4\n");
            Worker w1 = null;
            w1 = new President();
            w1.Print();
        }
    }
}
