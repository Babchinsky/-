using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_hw_13._02._2023
{
    internal class Manager : Worker
    {
        public Manager() { }
        public override void Print()
        {
            Console.WriteLine("Manager");
        }
    }
}
