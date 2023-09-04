using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_hw_08._03._2023_LINQ_2
{
    internal class Device
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\tManufacturer: {Manufacturer}\tCost: {Cost}";
        }
    }
}
