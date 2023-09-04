using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_hw_09._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            Task_4();
        }
        
        public static void Task_1()
        {
            Console.WriteLine("\n\n\t\t\tTask 1");
            Employee obj= new Employee();
            Console.WriteLine(obj + 240 - 240 + 125 - 35) ;
        }

        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2");
            Matrix a = new Matrix(new int[,] { { 1, 2, 3 }, { 1, 2, 3 } });
            Matrix b = new Matrix(new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } });

            if (a != b) Console.WriteLine("True");
            else Console.WriteLine("False");

            Matrix c = new Matrix();
            c = a * b;
            Console.WriteLine(c);
        }

        public static void Task_3()
        {
            Console.WriteLine("\n\n\t\t\tTask 3");
            City city= new City();
            Console.WriteLine(city + 10000);
        }

        public static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4");
            CreditCard c1 = new CreditCard();
            Console.WriteLine(c1 + 250);

        }
    }
}
