using System;
namespace CSharp.String
{
    class MainClass
    {
        static void Main()
        {
            double a = 10, b = 5, add, subtract, mult, div;
            Console.WriteLine("a = " + a + "\t b = " + b);
            NoSwap(a, b);
            Console.WriteLine("a = " + a + "\t b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("a = " + a + "\t b = " + b + "\n\n");

            int[] A = new int[] { 1, 2, 3 };
            Console.WriteLine("\n\nМассив A");
            foreach (int n in A)
                Console.Write("{0,4}", n);
            int[] B = new int[] { 4, 5, 6 };
            Console.WriteLine("\n\nМассив B");
            foreach (int n in B)
                Console.Write("{0,4}", n);

            NoSwapArray(A, B);

            Console.WriteLine("\n\nМассив A");
            foreach (int n in A)
                Console.Write("{0,4}", n);
            Console.WriteLine("\n\nМассив B");
            foreach (int n in B)
                Console.Write("{0,4}", n);

            SwapArray(ref A, ref B);

            Console.WriteLine("\n\nМассив A");
            foreach (int n in A)
                Console.Write("{0,4}", n);
            Console.WriteLine("\n\nМассив B");
            foreach (int n in B)
                Console.Write("{0,4}", n);

            string s1 = "C#", s2 = ".NET Framework";

            NoSwapString(s1, s2);

            Console.WriteLine("\n\nСтрока 1: " + s1);
            Console.WriteLine("\n\nстрока 2: " + s2);

            SwapString(ref s1, ref s2);

            Console.WriteLine("\n\nСтрока 1: " + s1);
            Console.WriteLine("\n\nстрока 2: " + s2);

            Calculate(a, b, out add, out subtract, out mult, out div);
            Console.WriteLine("\na = " + a + "\t b = " + b + "\n\n");
            Console.WriteLine("Сумма чисел " + add);
            Console.WriteLine("Разность чисел " + subtract);
            Console.WriteLine("Произведение чисел " + mult);
            Console.WriteLine("Деление чисел " + div);
        }

        static void NoSwap(double n, double m)
        {
            double temp = n;
            n = m;
            m = temp;
        }

        static void Swap(ref double n, ref double m)
        {
            double temp = n;
            n = m;
            m = temp;
        }

        static void NoSwapString(string n, string m)
        {
            string temp = n;
            n = m;
            m = temp;
        }

        static void SwapString(ref string n, ref string m)
        {
            string temp = n;
            n = m;
            m = temp;
        }

        static void NoSwapArray(int[] a, int[] b)
        {
            a[0] = 10;
            b[0] = 40;
            int[] temp = a;
            a = b;
            b = temp;
        }

        static void SwapArray(ref int[] a, ref int[] b)
        {
            a[0] = 100;
            b[0] = 400;
            int[] temp = a;
            a = b;
            b = temp;
        }

        static void Calculate(double n, double m, out double add, out double subtract, out double mult, out double div)
        {
            add = n + m;
            subtract = n - m;
            mult = n * m;
            div = n / m;
        }
    }
}