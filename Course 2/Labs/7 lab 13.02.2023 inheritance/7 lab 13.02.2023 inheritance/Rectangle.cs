using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Rectangle:Figure
    {
        private int ASide {get;set;}
        private int BSide { get;set;}

        public Rectangle() :this(1,1){ }
        public Rectangle(int ASide, int BSide) 
        {
            this.ASide = ASide;
            this.BSide = BSide;
        }
        public override double GetArea()
        {
            return ASide * BSide;
        }
        public override string ToString()
        {
            return $"Side A: {ASide}\nSide B: {BSide}";
        }
    }
}
