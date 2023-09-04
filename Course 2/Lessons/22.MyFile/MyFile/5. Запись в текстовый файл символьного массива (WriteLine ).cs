using System;
using System.IO;
using System.Text;
using System.Threading;

public class SWBuff
{
    public static void Main()
    {
        try
        {
            char[] b = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l' };
            StreamWriter sw = new StreamWriter("MyFile.txt", true);
            int j = 0;
            for (int i = 0; i < b.Length / 3; i++)
            {
                sw.WriteLine(b, j, 3);
                j += 3;
            }
            sw.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}