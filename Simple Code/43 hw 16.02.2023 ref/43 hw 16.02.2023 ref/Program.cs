using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_hw_16._02._2023_ref
{
    internal class Program
    {
        static void Main()
        {
            Task_1();
        }

        

        static void Task_1()
        {
            Console.WriteLine("\t\t\tTask 1\n");

            int[] ints= { 1, 2,3 };
            
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Resize(ref ints);
        }

        static void Resize(ref int[] arr)
        {
            arr = new int[10];
        }
    }
}
