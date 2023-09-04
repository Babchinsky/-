using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_6();
            Task_7();
        }


        static void Task_1()
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter a number from 1 to 100: ");            
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 1 || num > 100)
            {
                Console.WriteLine("Error. Number is not in diapasone");
                return;
            }

            if (num % 3 == 0 && num % 5 == 0) Console.WriteLine("Fizz Buzz");
            else if (num % 3 == 0) Console.WriteLine("Fizz");
            else if (num % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(num);

            Console.WriteLine();
        }
        static void Task_2()
        {
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter percents:"); 
            int percents = Convert.ToInt32(Console.ReadLine());

            double result = num / 100.0 * percents;
            Console.WriteLine($"Result: {result}");

            Console.WriteLine();
        }
        static void Task_3()
        {
            Console.WriteLine("Task 3");

            int[] num = new int[4];
            string result = "";

            for (int i = 0; i < 4; i ++)
            {
                Console.WriteLine($"Number {i + 1}:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                result += Convert.ToString(num[i]);
            }

            Console.WriteLine(result);

            Console.WriteLine();
        }
        static void Task_4()
        {
            Console.WriteLine("Task 4");
            Console.WriteLine("Enter 6-digits number:");
            int iNum = Convert.ToInt32(Console.ReadLine());
            string sNum = Convert.ToString(iNum);

            if (sNum.Length != 6) Console.WriteLine("Error. The number hasn't 6 digits");

            Console.WriteLine("Enter first digit:");
            int iDigitA = Convert.ToInt32(Console.ReadLine());
            iDigitA--;

            Console.WriteLine("Enter second digit:");
            int iDigitB = Convert.ToInt32(Console.ReadLine());
            iDigitB--;

            char[] result = new char[6];

            for (int i = 0; i < 6; i++)
                if (i != iDigitA|| i != iDigitB)
                    result[i] = sNum[i];

            result[iDigitA] = sNum[iDigitB];
            result[iDigitB] = sNum[iDigitA];


            for (int i = 0; i < result.Length; i++)
                Console.Write(result[i]);
            
            Console.WriteLine();
        }
        static void Task_5()
        {
            Console.WriteLine("Task 5");

            Console.WriteLine("Enter day: ");
            int sDay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month: ");
            int sMonth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter year: ");
            int sYear = Convert.ToInt32(Console.ReadLine());

            DateTime dt = new DateTime(sYear, sMonth, sDay);

            if (sMonth == 1 || sMonth == 2 || sMonth == 12) Console.Write("Winter ");
            else if (sMonth >= 3 && sMonth <= 5) Console.Write("Spring ");
            else if (sMonth >= 6 && sMonth <= 8) Console.Write("Summer ");
            else if (sMonth >= 9 && sMonth <= 11) Console.Write("Autumn ");

            Console.WriteLine(dt.DayOfWeek);

            Console.WriteLine();
        }
        static void Task_6()
        {
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter temperature:");
            int iUserTemp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Print 1 if you want convert your temperature to Fahrenheit or print C if you want convert to Celsium");
            int answer = Convert.ToInt32(Console.ReadLine());
            double result = 0;

            if (answer == 1) result = (iUserTemp - 32) * 5.0 / 9;
            else if (answer == 2) result = (iUserTemp * 9.0 / 5) + 32;
            Console.WriteLine($"Result: {result}");

            Console.WriteLine();
        }
        static void Task_7()
        {
            Console.WriteLine("Task 7");
            Console.WriteLine("Enter min value of diapasone:");
            int iMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max value of diapasone:");
            int iMax = Convert.ToInt32(Console.ReadLine());

            if (iMin > iMax) 
                (iMin, iMax) = (iMax, iMin);

            for (int i = iMin; i <= iMax; i++)
                if (i % 2 == 0) Console.Write($"{i}\t");

            Console.WriteLine();
        }
    }
}
