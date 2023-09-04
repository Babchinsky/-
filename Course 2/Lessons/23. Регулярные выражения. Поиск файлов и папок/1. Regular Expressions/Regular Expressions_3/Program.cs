using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // В исходной строке нужно найти все числа,
            // соответствующие годам выпуска языков программирования
            string input = "Выпуск первой официальной версии: " +
                "Язык программирования C++ - 1985 год. " +
                "Язык программирования Java - 1995 год. " +
                "Язык программирования C# - 2002 год. ";

            string pattern = @"(\d+)\s?год";
            Regex regex = new Regex(pattern);

            // Достигаем того же результата что и в предыдущем примере, 
            // используя метод Regex.Matches(), возвращающий MatchCollection
            MatchCollection mc = regex.Matches(input);
            foreach (Match match in mc)
            {
                Console.WriteLine(match.Groups[1].Value);
                Console.WriteLine(match.Value);
            }
        }
    }
}
