using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class RectangularTriangle:Figure
    {
        private int Cathetus_A { get; set; }
        private int Cathetus_B { get; set; }

        public RectangularTriangle() :this(10,20){ }
        public RectangularTriangle(int cathetus_A, int cathetus_B)
        {
            Cathetus_A = cathetus_A;
            Cathetus_B = cathetus_B;
        }

        public override double GetArea()
        {
            return Cathetus_A * Cathetus_B / 2;
        }

        public override string ToString()
        {
            return $"Cathetus A: {Cathetus_A}\nCathetus B: {Cathetus_B}";
        }

    }
}
