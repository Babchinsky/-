using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_lab_17._02._2023_delegate
{
    internal class Program
    {
        delegate void MyDelegate(string message);
        static void Show(string message)
        {
            Console.WriteLine(message);
        }
        static void Print(string message)
        {
            Console.WriteLine(message);
        }
        static void Output(string message)
        {
            Console.WriteLine(message);
        }
        static void Task_1()
        {
            Console.WriteLine("\n\t\t\tTask 1\n");
            MyDelegate m1 = Show;
            m1("Show");

            m1 = Print;
            m1("Print");

            m1 = Output;
            m1("Output");
        }



        delegate int Calc(int l, int r);
        static int Sum(int l, int r)
        {
            Console.WriteLine(l + r);
            return l + r;
        }
        static int Dif(int l, int r)
        {
            Console.WriteLine(l - r);
            return l - r;
        }
        static int Mult(int l, int r)
        {
            Console.WriteLine(l * r);
            return l * r;
        }
        static void Task_2()
        {
            Console.WriteLine("\n\t\t\tTask 2\n");
            Calc[] calc1 = { Sum, Dif, Mult};

            foreach (Calc method in calc1) 
            {
                method(1, 2);
            }
        }


        static bool isPerfectSquare(double x)
        {
            double s = Math.Sqrt(x);
            return (s * s == x);
        }

        delegate bool CheckNum(int num);

        static bool IsNumCheck(int num, CheckNum ptr)
        {
            return ptr(num);
        }
        static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static bool IsFibonacci(int num)
        {
            return isPerfectSquare(5 * num * num + 4)
           || isPerfectSquare(5 * num * num - 4);
        }


        static void Task_3()
        {
            Console.WriteLine("\n\t\t\tTask 3\n");
            Console.WriteLine(IsNumCheck(3, IsEven));
        }

        static void Task_4()
        {
            Console.WriteLine("\n\t\t\tTask 4\n");

            Calc calc1 = new Calc(Sum);
            calc1 += Dif;
            calc1 += Mult;

            calc1.Invoke(12,5);
        }
        static void Main()
        {
            //Task_1();
            //Task_2();
            Task_3();
            //Task_4();
        }
    }
}
