// Перенаправление потока Console.In.
using System;
using System.IO;
using System.Text;

class Redirect
{
    public static void Main()
    {
        try
        {
            StreamReader log_in = new StreamReader("music.txt", Encoding.UTF8);
            TextReader tmp = Console.In;
            Console.SetIn(log_in);
            for (int i = 0; i < 10; i++)
                Console.WriteLine(Console.ReadLine());
            log_in.Close();
            Console.SetIn(tmp);
            for (int i = 0; i < 3; i++)
                Console.WriteLine(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

