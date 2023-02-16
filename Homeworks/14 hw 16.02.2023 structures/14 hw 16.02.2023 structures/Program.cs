using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_hw_16._02._2023_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            Task_3();
        }

        public static void Task_1()
        {
            Console.WriteLine("\n\t\tTask 1\n");
            Vector3D v1 = new Vector3D(3, 1, 4);
            Vector3D v2 = new Vector3D(-3, 6, 2);
            Vector3D v3 = v2 - v1;
            Console.WriteLine(v3);
        }
         
        public static void Task_2()
        {
            Console.WriteLine("\n\t\tTask 2\n");
            DecimalNumber d1 = new DecimalNumber(121);
            string d1b = d1.ToBinary();
            Console.WriteLine(d1);
        }

        public static void Task_3()
        {
            Console.WriteLine("\n\t\tTask 3\n");
            RgbColor obj1 = new RgbColor(123,77,23);
            Console.WriteLine(obj1);
            Console.WriteLine(obj1.ToHex());
            Console.WriteLine(obj1.ToHsl());
            Console.WriteLine(obj1.ToCmyk());
        }
    }
}
