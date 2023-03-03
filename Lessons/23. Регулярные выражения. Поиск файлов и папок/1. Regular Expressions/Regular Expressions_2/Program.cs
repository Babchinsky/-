using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_3
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

            // Получаем совпадения в экземпляре класса Match
            Match match = regex.Match(input);

            // отображаем все совпадения
            while (match.Success)
            {
                // Т.к. мы выделили в шаблоне одну группу (одни круглые скобки),
                // ссылаемся на найденное значение через свойство Groups класса Match
                Console.WriteLine(match.Groups[1].Value);
                Console.WriteLine(match.Value);
                // Переходим к следующему совпадению
                match = match.NextMatch();
            }
        }
    }
}
