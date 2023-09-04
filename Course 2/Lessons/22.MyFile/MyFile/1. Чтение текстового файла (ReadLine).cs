using System;
using System.IO;
using System.Text;
using System.Threading;

class Test
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Введите путь к файлу: ");
            string filename = Console.ReadLine();
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                Thread.Sleep(100);
            }
            sr.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}