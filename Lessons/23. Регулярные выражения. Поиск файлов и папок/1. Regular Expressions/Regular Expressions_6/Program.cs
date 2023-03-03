using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string Input = Console.ReadLine();
            string pattern = @"^(-|\+|)\d+(\.\d+)?$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(Input))
                Console.WriteLine("Некорректный ввод!");
            else
                Console.WriteLine("Число введено правильно!");
        }
    }
}
