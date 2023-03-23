 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_hw_23._03._2023_Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Truck("Mercedes-Benz", 1979, new Engine(125, 2.8, "Дизель", 16));
            Transport transport1= transport.Clone();

            transport1.Show();
        }
    }
}
