using System;
using System.IO;
using System.Text;
using System.Threading;

class Simple
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Введите путь к файлу: ");
            string path = Console.ReadLine();
            FileStream file1 = new FileStream(path, FileMode.Open, FileAccess.Read);
            long len = file1.Length;
            BinaryReader reader = new BinaryReader(file1);
            byte[] buf = new byte[len];
            reader.Read(buf, 0, (int)len);
            reader.Close();
            file1.Close();
            FileStream file2 = new FileStream("copy.jpg", FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file2);
            writer.Write(buf, 0, (int)len);
            writer.Close();
            file2.Close();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}