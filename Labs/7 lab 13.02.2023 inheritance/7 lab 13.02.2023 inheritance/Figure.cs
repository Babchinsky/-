using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal abstract class Figure
    {
        public Figure() { }

        public abstract double GetArea();
        public abstract override string ToString();
    }
}
