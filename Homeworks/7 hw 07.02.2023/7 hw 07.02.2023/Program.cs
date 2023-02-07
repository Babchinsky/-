using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_hw_07._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector first = new Vector(1, 2, 3);
            Vector second = new Vector(4, 5, 6);
            Console.WriteLine(first);
            //Console.WriteLine(first.GetLength());
            //Console.WriteLine(first.EqualityTest(second));
            Console.WriteLine(first.GetCorner(second));
        }
    }
}
