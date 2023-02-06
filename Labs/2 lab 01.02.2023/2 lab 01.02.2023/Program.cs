using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace _2_lab_01._02._2023
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
            //Task_8();
            //Task_9();
        }

        public static void Task_1()
        {
            Console.WriteLine("\t\tTask 1");
            int[] iArr = new int[10];
            int Min = 1;
            int Max = 20;
            Random randNum = new Random();

            for (int i = 0; i < iArr.Length; i++)
                iArr[i] = randNum.Next(Min, Max);

            foreach (int element in iArr)
                Console.Write("{0, 4}", element);

            int iNumberOfEven = 0;
            int iNumberOfOdd = 0;
            int iNumberOfUnique = iArr.Distinct().Count();

            foreach (int el in iArr)
            {
                if (el % 2 == 0)
                    iNumberOfEven++;
                else iNumberOfOdd++;
            }

            Console.WriteLine($"\nEven: {iNumberOfEven}");
            Console.WriteLine($"Odd: {iNumberOfOdd}");
            Console.WriteLine($"Unique: {iNumberOfUnique}\n");
        }
        public static void Task_2()
        {
            Console.WriteLine("\t\tTask 2");
            int[] iArr = new int[10];
            int Min = 1;
            int Max = 20;
            Random randNum = new Random();

            for (int i = 0; i < iArr.Length; i++)
                iArr[i] = randNum.Next(Min, Max);

            foreach (int element in iArr)
                Console.Write("{0, 4}", element);

            Console.WriteLine("\nEnter number to find elements less than that number:");
            int iNum = Convert.ToInt32(Console.ReadLine());

            foreach (int el in iArr)
                if (el < iNum) Console.Write(el + " ");
           
            Console.WriteLine("");
        }
        public static void Task_3()
        {
            Console.WriteLine("\t\tTask 3");
            int[] iArr = { 7,6 ,5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            
            foreach (int element in iArr)
                Console.Write("{0, 4}", element);

            int[] iNums = new int[3];
            Console.WriteLine();
            for (int i = 0;i < iNums.Length; i++)
            {
                Console.Write($"Enter number {i + 1}:");
                iNums[i] = Convert.ToInt32(Console.ReadLine());
            }

            int iNumberOfSeries = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == iNums[0] && iArr[i + 1] == iNums[1] && iArr[i + 2] == iNums[2])
                    iNumberOfSeries++;
            }

            Console.WriteLine("Number of series " + iNumberOfSeries);
        }
        public static void Task_4()
        {
            Console.WriteLine("\t\tTask 4");
            int[] iArrA = { 7, 3, 5, 0, 7 };
            int[] iArrB = { 7, 6, 5, 3, 4, 8, 1, 3, 8, 7, 9, 5 };
            List<int> iListC = new List<int>();

            foreach (int element in iArrA)
                Console.Write(element + "\t");

            Console.WriteLine();

            foreach (int element in iArrB)
                Console.Write(element + "\t");

            // добавление элементов в список и проверка
            foreach (int elementA in iArrA)
            {
                foreach (int elementB in iArrB)
                {
                    if (elementA == elementB && !(iListC.Contains(elementA)))
                    {
                        iListC.Add(elementA);
                    }
                }
            }

            Console.WriteLine();
            iListC.ForEach(Console.WriteLine);
        }
        public static void Task_5()
        {
            Console.WriteLine("\t\tTask 5");
            int[,] i2DArr = { { 1, 23, 57, 36, 19 }, { 2, 129, 17, 14, 16 } };

            int iMin = i2DArr[0,0];
            int iMax = i2DArr[0,0];

            foreach (int element in i2DArr) 
            {
                Console.Write(element + "\t");
                if (element < iMin) iMin = element;
                if (element > iMax) iMax = element;
            }

            Console.WriteLine($"\nMin: {iMin}\nMax: {iMax}");
        }
        public static void Task_6()
        {
            Console.WriteLine("\t\tTask 6");
            Console.WriteLine("Enter a sentence:");

            string text = Console.ReadLine();
            int wordCount = 0, index = 0;

            // пропускаем проблем до первого слова
            while (index < text.Length && char.IsWhiteSpace(text[index]))
                index++;

            while (index < text.Length)
            {
                // проверка на то, является ли символ частью слова
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;

                wordCount++;

                // пропуск пробела до следующего слова
                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }

            Console.WriteLine($"Number of words: {wordCount}");
        }
        public static void Task_7()
        {
            Console.WriteLine("\t\tTask 7");
            Console.WriteLine("Enter a sentence:");

            string text = Console.ReadLine();
            char[] delimeters = {' ', '\n', '\r'};
            string[] words_arr = text.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
       
            //char[] reverse_word_buf = new char[32];
            StringBuilder result = new StringBuilder();

            foreach (string word in words_arr)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word[word.Length - i - 1]);
                }
                result.Append(' ');
            }
            Console.Write(result);
        }
        public static void Task_8()
        {
            Console.WriteLine("\t\tTask 8");
            Console.WriteLine("Enter the string: ");
            string text = Console.ReadLine();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
            int number_of_vowels = 0;

            foreach (char ch in text)
            {
                if (vowels.Contains(ch) == true) number_of_vowels++;
            }

            Console.WriteLine("Number of vowels: " + number_of_vowels);
        }
        public static void Task_9()
        {
            Console.WriteLine("\t\tTask 9");
            Console.WriteLine("Enter the string: ");
            string text = Console.ReadLine();

            Console.WriteLine("Enter the substring to count it in text: ");
            string substr = Console.ReadLine();

            int number_of_occurencies = Regex.Matches(text, substr).Count;

            Console.WriteLine("Number of substrings: " + number_of_occurencies);
        }
    }
}
