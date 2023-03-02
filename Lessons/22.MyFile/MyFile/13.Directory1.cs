using System;
using System.IO;
namespace MyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(".");
            Console.WriteLine($"Full path to the directory:{ dir.FullName}");
            Console.WriteLine($"Time of creation: { dir.CreationTime}");
            Console.WriteLine("\n\tAll directory files:");
            FileInfo[] files = dir.GetFiles(); // все файлы 
                                               // в каталоге
            foreach (FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine();
        }
    }
}
