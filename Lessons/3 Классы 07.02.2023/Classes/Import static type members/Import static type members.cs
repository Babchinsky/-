// Импорт членов статических типов в пространство имён

// Выражение using static подключает в программу все статические методы и свойства, 
// а также константы. И после этого мы можем не указывать название класса при вызове метода.

using static System.Console;

namespace New_in_CSharp_6
{ 
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello from C# 6.0");
            Read();
        }
    }
}
