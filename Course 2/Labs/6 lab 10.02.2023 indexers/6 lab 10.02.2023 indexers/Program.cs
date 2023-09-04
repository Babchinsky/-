using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab_10._02._2023_indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix m = new Matrix(new int[,] { { 1,2,3}, { 4,5,6} });
            Console.WriteLine(m);

            try 
            { 
                Console.WriteLine(m[4,5]);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }



        }
    }
}
