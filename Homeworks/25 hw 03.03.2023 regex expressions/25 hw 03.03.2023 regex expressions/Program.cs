using System;
using System.Text.RegularExpressions;

namespace _24_hw_03._03._2023_regex_expressions
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
            //Task_7();
            Task_8();
        }
        static void Task_1()
        {
            string input = "ahb acb aeb aeeb adcb axeb";
            string pattern = @"[a]\w{1}[b]";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_2()
        {
            string input = "aba aca aea abba adca abea";
            string pattern = @"[a]\w{2}[a]";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_3()
        {
            string input = "aba aca aea abba adca abea";
            string pattern = @"[a][b]\w{1}[a]";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_4()
        {
            string input = "aa aba abba abbba abca abea";
            string pattern = @"ab+a";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_5()
        {
            string input = "aa aba abba abbba abca abea";
            string pattern = @"ab*a";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_6()
        {
            string input = "aa aba abba abbba abca abea";
            string pattern = @"ab?a";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_7()
        {
            string input = "aa aba abba abbba abca abea";
            string pattern = @"ab*a";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
        static void Task_8()
        {
            string input = "ab abab abab abababab abea";
            string pattern = @"(ab)+\s";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(input);

            while (match.Success)
            {
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
    }
}