// Перенаправление потока Console.Out.
using System;
using System.IO;
using System.Text;

class Redirect
{
    public static void Main()
    {
        try
        {
            StreamWriter log_out = new StreamWriter("logfile.txt", false, Encoding.UTF8);
            TextWriter tmp = Console.Out;
            Console.SetOut(log_out);
            Console.WriteLine("Это начало системного журнала.");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            Console.WriteLine("Это конец системного журнала.");
            log_out.Close();
            Console.SetOut(tmp);
            Console.WriteLine("Это начало системного журнала.");
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);
            Console.WriteLine("Это конец системного журнала.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}