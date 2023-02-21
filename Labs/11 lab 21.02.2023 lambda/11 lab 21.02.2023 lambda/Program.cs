using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_hw_21._02._2023_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            Task_4();
            Task_5();
            Task_6();
            Task_7();
        }

        delegate bool Is(int num);
        static void Task_1()
        {
            //Is even = delegate (int num)
            //{
            //    return num % 2 == 0;
            //};

            Is even = num => num % 2 == 0;

            Console.WriteLine(even(13));
        }

        delegate int Do(int num);
        static void Task_2()
        {
            //Do sqare = delegate (int num)
            //{
            //    return num * num;
            //};
            Do sqare = num => num * num;
            Console.WriteLine(sqare(12));
        }

        static void Task_3()
        {
            //Do cube = delegate (int num)
            //{
            //    return num * num * num;
            //};
            Do cube = num => num * num * num;
            Console.WriteLine(cube(2));
        }

        static void Task_4()
        {
            //Is programmersDay = delegate (int day)
            //{
            //    if (day > 355) throw new Exception("Максимум в году 355 дней");

            //    if (day == 256) return true;
            //    else return false;
            //};
            Is programmersDay = num => num == 256;
            Console.WriteLine(programmersDay(256));
        }

        delegate int Find(int[] arr);
        static void Task_5()
        {
            Find max = delegate (int[] arr)
            {
                int maxNum = arr[0];
                foreach (int element in arr)
                {
                    if (element > maxNum) maxNum = element;
                }

                return maxNum;
            };

            //Find max = arr[] => 
            int[] arr1 = { 1, 27, 1, 3, 22 };
            Console.WriteLine(max(arr1));
        }

        static void Task_6()
        {
            Find min = delegate (int[] arr)
            {
                int minNum = arr[0];
                foreach (int element in arr)
                {
                    if (element < minNum) minNum = element;
                }

                return minNum;
            };
            int[] arr1 = { 1, 27, 1, 3, 22 };
            Console.WriteLine(min(arr1));
        }

        static void Task_7()
        {
            Find countOfOdd = delegate (int[] arr)
            {
                int count = 0;
                foreach (int element in arr)
                {
                    if (element % 2 != 0) count++;
                }

                return count;
            };
            int[] arr1 = { 1, 27, 1, 3, 22 };
            Console.WriteLine(countOfOdd(arr1));
        }
    }
}
