using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Trapeze:Figure
    {   
        private int Height { get; set; }
        private int Medium { get; set; }

        public Trapeze() : this(10, 20) { }
        public Trapeze(int height, int medium)
        {
            Height = height;
            Medium = medium;
        }

        public override double GetArea()
        {
            return Medium * Height;
        }

        public override string ToString()
        {
            return $"Medium: {Medium}\nHeight: {Height}";
        }
    }
}
