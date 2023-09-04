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
            FileStream file = new FileStream("1.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            writer.Write("Привет!!!");
            writer.Write("C#!!!");
            writer.Write('A');
            writer.Write(65.78);
            writer.Write(true);
            writer.Close();
            file.Close();
            file = new FileStream("1.dat", FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(file);
            string s1 = reader.ReadString();
            string s2 = reader.ReadString();
            char c = reader.ReadChar();
            double d = reader.ReadDouble();
            bool b = reader.ReadBoolean();
            Console.WriteLine("string: {0}\nstring: {1}\nchar: {2}\ndouble: {3}\nbool: {4}", 
                s1, s2, c, d, b);
            reader.Close();
            file.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
}