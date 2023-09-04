using System;
using System.IO;
using System.Text;

class Test
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Введите путь к файлу: ");
            string filename = Console.ReadLine();
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}