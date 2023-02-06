using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lab_31._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_5();
            Task_6();
        }
        public static void Task_1()
        {
            Console.WriteLine("\n\t\tTask 1");
            Console.WriteLine("It's easy to win forgiveness for being wrong; \n" +
                "being right is what gets you into real trouble." +
                "\nBjarne Stroustrup");
        }
        public static void Task_2()
        {
            Console.WriteLine("\n\t\tTask 2");

            int[] iArr = new int[5];

            int iSum = 0, iMax = 0, iMin = 0, iProduct = 1;

            for (int i = 0; i < iArr.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                iArr[i] = Convert.ToInt32(Console.ReadLine());

                iSum += iArr[i];
                iProduct *= iArr[i];

                if (iArr[i] > iMax) iMax = iArr[i];
                if (iArr[i] < iMin) iMin = iArr[i];
            }
            Console.WriteLine($"Sum: {iSum}\nProduct: {iProduct}\nMin: {iMin}\nMax: {iMax}");
        }
        public static void Task_3()
        {
            Console.WriteLine("\n\t\tTask 3");



            int num, reverse = 0, rem;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Reversed Number: " + reverse);
        }
        public static void Task_4()
        {
            Console.WriteLine("\n\t\tTask 4");

            Console.Write("Enter left value of diapasone: ");
            int iLeft = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter right value of diapasone: ");
            int iRight = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            for (;c <= iRight;)
            {
                c = a + b;
                if (c >= iLeft && c <= iRight)
                    Console.Write($"{c}\t");
                a = b;
                b = c;
            }
        }
        public static void Task_5()
        {
            Console.WriteLine("\n\t\tTask 5");

            Console.Write("Enter left value of diapasone: ");
            int iMin = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter right value of diapasone: ");
            int iMax = Convert.ToInt32(Console.ReadLine());

            for (int i = iMin; i <= iMax; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i}\t");
                }
                Console.WriteLine();
            }

        }
        public static void Task_6()
        {
            Console.WriteLine("\n\t\tTask 6");

            Console.Write("Enter number of symbols: ");
            int iNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 0 to draw horizontal line or 1 to draw vertical: ");
            int iDirection = Convert.ToInt32(Console.ReadLine());

            if (iDirection == 0 ) 
                for (int i = 0; i < iNum; i++)
                    Console.Write($"+");
            else if (iDirection == 1)
                for (int i = 0; i < iNum; i++)
                    Console.WriteLine($"+");
        }
    }
}
