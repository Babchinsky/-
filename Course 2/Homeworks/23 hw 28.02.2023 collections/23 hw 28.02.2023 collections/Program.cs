using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    static void Main()
    {
        // создаем словарь
        Dictionary<string, string> countryDict = new Dictionary<string, string>();

        // добавляем пары слов - названий стран на русском и английском языках
        countryDict.Add("Russia", "Россия");
        countryDict.Add("USA", "США");
        countryDict.Add("China", "Китай");
        countryDict.Add("France", "Франция");
        countryDict.Add("Germany", "Германия");

        // запрашиваем направление перевода и слово для перевода
        Console.Write("Выберите направление перевода (1 - англо-русский, 2 - русско-английский): ");
        int direction = int.Parse(Console.ReadLine());
        Console.Write("Введите слово для перевода: ");
        string word = Console.ReadLine();

        // переводим слово в соответствии с выбранным направлением
        string translation = "";
        if (direction == 1)
        {
            countryDict.TryGetValue(word, out translation);
        }
        else if (direction == 2)
        {
            translation = countryDict.FirstOrDefault(x => x.Value == word).Key;
        }

        // выводим результат перевода
        if (string.IsNullOrEmpty(translation))
        {
            Console.WriteLine("Слово не найдено");
        }
        else
        {
            Console.WriteLine("Перевод: " + translation);
        }
    }
}
