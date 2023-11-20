using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Создаем список строк
        List<string> listOfStrings = new List<string>
        {
            "Привет, мир!",
            "Это пример кода на C#.",
            "Строки и подстроки",
            "Программирование весело!",
            "Подстрока в этой строке"
        };

        // Получаем подстроку от пользователя
        Console.Write("Введите подстроку: ");
        string searchString = Console.ReadLine();

        // Выводим строки, содержащие введенную подстроку (регистронезависимо)
        Console.WriteLine("Результаты:");

        foreach (string str in listOfStrings)
        {
            if (str.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine(str);
            }
        }
    }
}
