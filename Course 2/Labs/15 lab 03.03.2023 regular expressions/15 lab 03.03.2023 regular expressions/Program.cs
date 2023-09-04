using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace _15_lab_03._03._2023_regular_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();

            //Task_7();
            //Task_8();
            //Task_9();
            //Task_10();
            //Task_11();
            Task_12();
        }
        static void Task_1()
        {
            string input = "kristest93@gmail.com";
            string pattern = @"(\w*)(@gmail.com)";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

            Console.WriteLine(match.Value);
        }
        static void Task_2()
        {
            string input = "+38098-499-40-84";
            string pattern = @"(\+*)(380)(\d{2})(-)(\d{3})(-)(\d{2})(-)(\d{2})";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

            Console.WriteLine(match.Value);
        }

        static void Task_7()
        {
            string input = "192.0.255.11";
            string pattern = @"(((([2][0-5][0-5])|([0|1]*[0-9][0-9])|([0-9]))(\.)){3})(([2][0-5][0-5])|([0|1]*[0-9][0-9])|([0-9]))";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            Console.WriteLine(match.Value);
        }
        static void Task_8()
        {
            string input = "Подсчёт количества гласных в заданой строке";
            string pattern = @"[ё]|[у]|[е]|[ы]|[а]|[о]|[э]|[я]|[и]|[ю]";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            int count = 0;
            // отображаем все совпадения
            while (match.Success)
            {
                Console.WriteLine(match.Value);
                count++;
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }

            Console.WriteLine("Количество гласных: " + count);
        }
        static void Task_9()
        {
            string input = "https://www.regex101.com/r/qAvMmc/1";
            string pattern = @"(http)[s *](://)www\.(\w+)\.(\w+)";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            Console.WriteLine(match.Value);
        }
        static void Task_10()
        {
            string input = "fsdfasfd123123";
            string pattern = @"^\w+$";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            if (match.Success) Console.WriteLine("Значение является авлфавитно-цифровым");
            else Console.WriteLine("Значение НЕ является авлфавитно-цифровым");
        }
        static void Task_11()
        {
            string input = "2:59:22";
            string pattern = @"([1][0-9]|[2][0-3]|((0?)[0-9]):[0-5][0-9]|((0?)[0-9]))(:[0-5][0-9]|((0?)[0-9]))?";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            Console.WriteLine(match.Value);
        }
        static void Task_12()
        {
            string input = "99950";
            string pattern = @"\d{5}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);
            Console.WriteLine(match.Value);
        }
    }
}
