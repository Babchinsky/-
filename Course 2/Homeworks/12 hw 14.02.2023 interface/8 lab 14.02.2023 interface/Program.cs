using _8_lab_14._02._2023_interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_hw_14._02._2023_interface
{
    internal class Program
    {
        static void Main()
        {
            IOutput ptr = new MyArray(new int[] { 68, 19, 12, 44,12,68 });
            ptr.Show();
            //ptr.Show("Info\n\n");

            //Console.WriteLine("Min: " + (ptr as IMath).Min());
            //Console.WriteLine("Max: " + (ptr as IMath).Max());
            //Console.WriteLine("Avg: " + (ptr as IMath).Avg());

            //if ((ptr as IMath).Search(12) == true)
            //{
            //    Console.WriteLine("True");
            //}
            //else Console.WriteLine("False");

            //(ptr as ISort).SortByParam(false);
            //ptr.Show();

            Console.WriteLine("\n" + (ptr as ICalc).Less(30));
            Console.WriteLine((ptr as ICalc).Greater(30));
            Console.WriteLine((ptr as ICalc2).CountDistinct());

            
        }
    }
}
