using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время в формате часы:минуты[:секунды] либо часы.минуты[.секунды]");
            string Input = Console.ReadLine();
            string pattern = @"^(([01][0-9])|([2][0-3]))(:|\.)[0-5][0-9]((:|\.)[0-5][0-9])?$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(Input))
                Console.WriteLine("Время введено правильно!");
            else
                Console.WriteLine("Время введено не правильно!");
        }
    }
}
