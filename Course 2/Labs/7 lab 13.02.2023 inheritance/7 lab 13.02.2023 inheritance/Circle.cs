using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Circle:Figure
    {
        private int Radius { get; set; }
        public Circle() : this(10) { }

        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $"Radius: {Radius}";
        }
    }
}
