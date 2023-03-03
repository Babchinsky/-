using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string myText = @"Сериализация представляет собой процесс сохранения объекта на диске. 
В другой части приложения или даже в совершенно отдельном приложении может производиться
десериализация объекта, возвращающая его в состояние, в котором он пребывал до сериализации.";

            string myReg = "Сериал";
            MatchCollection myMatch = Regex.Matches(myText, myReg, RegexOptions.IgnoreCase);

            Console.WriteLine("Все вхождения строки \"{0}\" в исходной строке: ", myReg);
            foreach (Match i in myMatch)
                Console.Write("\t" + i.Index);

            myReg = @"\b[с,д]\w*ериализац\w*";
            MatchCollection match = Regex.Matches(myText, myReg, RegexOptions.IgnoreCase);
            Console.WriteLine("\n");
            findMyText(myText, match);

            Console.ReadLine();
        }

        static void findMyText(string text, MatchCollection myMatch)
        {
            // Реализуем выделение ключевых слов в консоли другим цветом
            for (int i = 0; i < text.Length; i++)
            {
                foreach (Match m in myMatch)
                {
                    if ((i >= m.Index) && (i < m.Index + m.Length))
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.Write(text[i]);
            }

        }
    }
}
