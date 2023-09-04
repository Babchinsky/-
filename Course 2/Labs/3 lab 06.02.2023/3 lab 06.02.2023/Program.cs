using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_06._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_4();
            //Task_5();
            //Task_6();
            Task_7();
        }

        static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4");

            City Odesa = new City();
            Odesa.Name_City = "Odesa";
            Odesa.Name_Country = "Ukraine";
            Odesa.Residents = 968231;
            Odesa.Phone_Code = "+38";
            Odesa.Areas = new string[] { "Odeska", "Kyivska" };
            Console.WriteLine(Odesa);
        }
        static void Task_5()
        {
            Console.WriteLine("\n\n\t\t\tTask 5");
            Employee first = new Employee("Oleg Petrov Viktorovich", "21.09.2010", "+380682567388", "asdfas@gmail.com", "Senior C# Developer", "Coding");
            Console.WriteLine(first);
        }
        static void Task_6()
        {
            Console.WriteLine("\n\n\t\t\tTask 6");
            Plane first = new Plane("Test", "Test", "Test", "Test");
            Console.WriteLine(first);
        }
        static void Task_7()
        {
            Console.WriteLine("\n\n\t\t\tTask 7");
            Matrix m1 = new Matrix(new int[,] { { 1,2,3}, {4,5,6 } } );
            Console.WriteLine(m1);
            Console.WriteLine($"Min: {m1.GetMin()}\nMax: {m1.GetMax()}");
        }
    }
}
