using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "один два три четыре пять шесть";
            Console.WriteLine("Исходная строка:\n{0}", input);
            // В шаблоне используются 5 групп
            string pattern = @"\b(\w+)(\s)(\w+)(\s)(\w+)\b";
            string replacement = "$5$4$3$2$1"; 
            // исходная строка заменяется на 5 групп
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);

            input = "1000000 USD";
            Console.WriteLine("\nИсходная строка:\n{0}", input);
            pattern = @"\b(\d+)\s?USD";
            replacement = "$$$1";    // $$ - подставляет литерал "$"
            // исходная строка заменяется на 1 группу
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);   

            input = "AABBCCDD";
            Console.WriteLine("\nИсходная строка:\n{0}", input);
            pattern = "C+";
            replacement = "$`";
            // найденный фрагмент текста заменяется на подстроку 
            // входной строки до соответствия шаблона поиска
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);

            input = "AABBCCDD";
            Console.WriteLine("\nИсходная строка:\n{0}", input);
            pattern = "C+";
            replacement = "$'";
            // найденный фрагмент текста заменяется на подстроку 
            // входной строки после соответствия шаблона поиска
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);

            input = "AABBCCDDEE";
            Console.WriteLine("\nИсходная строка:\n{0}", input);
            pattern = "(A+)(B+)(C+)";
            replacement = "$+";
            // найденный фрагмент текста заменяется на последнюю захваченную группу
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);

            input = "AABBCC";
            Console.WriteLine("\nИсходная строка:\n{0}", input);
            pattern = "B";
            replacement = "$_";
            // входная строка заменяет все соответствия шаблона поиска
            input = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("\nВидоизмененная строка: \n" + input);
        }
    }
}
