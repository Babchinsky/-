using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lesson_14._02._2023_interface
{
    internal class Program
    {
        static void Main()
        {
            //IMove ptr = null;
            //ptr = new Student("Igor", 18, "College");
            //ptr.Move();
            //ptr.Print();

            //ptr = new Camel("Bob");
            //ptr.Move();
            //ptr.Print();


            IMove[] arr = new IMove[4];

            arr[0] = new Airplane("F-16");
            arr[1] = new Teacher("Oleg", 42, "IT Step");
            arr[2] = new Camel("Bob");
            arr[3] = new Student("Igor", 20, "IT Step");
           
            foreach (IMove element in arr) 
            {
                element.Move();
                element.Print();
                Console.WriteLine();
            }
        }
    }
}
