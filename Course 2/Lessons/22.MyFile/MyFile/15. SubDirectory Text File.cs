using System;
using System.IO;
using static System.Console;

namespace SimpleProject
{
    class Program
    {
        static void WriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                WriteLine("Enter the data to write to the file:");
                string writeText = ReadLine();
                sw.WriteLine(writeText);
                foreach (var item in writeText)
                {
                    sw.Write($"{item} ");
                }
                WriteLine("\nData recorded!");
            }
        }
        static string ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                return sr.ReadToEnd();
            }
        }
    
        static void Main()
        {
            string path = @"C:/Test/Subdir1/Test.txt";
            try
            {
                WriteFile(path);
                WriteLine($"\nData read from the file:\n");
                WriteLine(ReadFile(path));
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            WriteLine();
        }
    }
}
