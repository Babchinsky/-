using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lab_14._02._2023_interface
{
    internal class Program
    {
        static void Main()
        {
            IOutput ptr = new MyArray(new int[] { 68, 19, 12, 44 });
            //ptr.Show();
            ptr.Show("Info\n\n");

            Console.WriteLine("Min: " + (ptr as IMath).Min());
            Console.WriteLine("Max: " + (ptr as IMath).Max());
            Console.WriteLine("Avg: " + (ptr as IMath).Avg());

            if ((ptr as IMath).Search(12) == true)
            {
                Console.WriteLine("True");
            }
            else Console.WriteLine("False");

            (ptr as ISort).SortByParam(false);
            ptr.Show();
        }
    }
}
