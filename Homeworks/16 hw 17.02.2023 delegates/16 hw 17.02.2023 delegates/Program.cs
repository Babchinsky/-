using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_hw_17._02._2023_delegates
{
    internal class Program
    {
        static void Main()
        {
            //Task_1();
            Task_2();
        }

        static bool isPerfectSquare(double x)
        {
            double s = Math.Sqrt(x);
            return (s * s == x);
        }
        static bool IsFibonacci(int num)
        {
            return isPerfectSquare(5 * num * num + 4)
           || isPerfectSquare(5 * num * num - 4);
        }
        static void Print(int[] arr)
        {
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
        }

        delegate int[] GetFromArr(int[] arr);

        static int[] GetEvenFromArr(int[] arr)
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el % 2 == 0) count++;
            }

            int[] result = new int[count];

            count = 0;
            foreach (int el in arr)
            {
                if (el % 2 == 0) result[count++] = el;
            }
            return result;
        }
        static int[] GetOddFromArr(int[] arr)
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el % 2 != 0) count++;
            }

            int[] result = new int[count];

            count = 0;
            foreach (int el in arr)
            {
                if (el % 2 != 0) result[count++] = el;
            }
            return result;
        }
        static int[] GetPrimeNumsFromArr(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = 2;
                int p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    count++;
                }
            }
            int[]result = new int[count];
            count = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                int j = 2;
                int p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    result[count++] = arr[i];
                }
            }


            return result;
        }
        static int[] GetFibonacciFromArr(int[] arr)
        {
            int count = 0;

            foreach (int el in arr)
            {
                if (IsFibonacci(el) == true) count++;
            }

            int[] result = new int[count];
            count = 0;

            foreach (int el in arr)
            {
                if (IsFibonacci(el) == true) result[count++] = el;
            }

            return result;
        }

        static void Task_1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            GetFromArr funcs = GetEvenFromArr;
            Print(arr);

            int[] arr2 = funcs(arr);
            Print(arr2);

            funcs = GetOddFromArr;
            int[] arr3 = funcs(arr);
            Print(arr3);

            funcs = GetPrimeNumsFromArr;
            int[] arr4 = funcs(arr);
            Print(arr4);

            funcs = GetFibonacciFromArr;
            int[] arr5 = funcs(arr);
            Print(arr5);
        }





        delegate void DateDelegate();

        static void CurrentTime()
        {
            DateTime current_time = DateTime.Now;
            Console.WriteLine(current_time.ToString("HH:mm:ss"));
        }

        static void CurrentDate()
        {
            DateTime current_date = DateTime.Now;
            Console.WriteLine(current_date.ToString("dd.MM.yyyy"));
        }

        static void CurrentDayOfWeek()
        {
            DateTime current_date = DateTime.Now;
            Console.WriteLine(current_date.DayOfWeek);
        }

        delegate int GetAreaDg(int sideA, int sideB, int sideC);

        static int GetTriangleArea(int sideA, int sideB, int sideC)
        {
            return 0;
        }

        static int GetRectangleArea(int sideA, int sideB, int sideC)
        {
            return 1;
        }

        static int GetArea(int sideA, int sideB, int sideC, GetAreaDg dg)
        {
            return dg(sideA, sideB, sideC);
        }

        static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2\n");

            DateDelegate ddg = CurrentDate;
            ddg += CurrentDate;
            ddg += CurrentDayOfWeek;

            ddg();

            GetAreaDg ptr = GetTriangleArea;
            Console.WriteLine(   GetArea(1, 2, 3, GetRectangleArea)      );
        }
    }
}
