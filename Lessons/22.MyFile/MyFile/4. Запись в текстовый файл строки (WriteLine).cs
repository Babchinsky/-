using System;
using System.IO;
using System.Text;
using System.Threading;

class WriteSomeFile
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите любой текст.");
            StreamWriter sw = new StreamWriter("User.log", true);
            string line;
            do
            {
                // Считываем строку с клавиатуры
                line = Console.ReadLine();
                // Записываем строку в файл
                sw.WriteLine(line);
            } while (line != "");

            sw.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}