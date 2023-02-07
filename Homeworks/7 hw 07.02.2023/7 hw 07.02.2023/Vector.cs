using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_hw_07._02._2023
{
    internal class Vector
    {
        private int x;
        private int y;
        private int z;

        public Vector()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector(int x)
        {
            this.x = x;
            this.y = x;
            this.z = x;
        }

        public Vector(int x, int y) : this(x)
        {
           this.y = y;
           this.z = y;
        }
        public Vector(int x, int y, int z) : this(x, y)
        {
            this.z = z;
        }

        public void Input()
        {
            Console.Write("Enter x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter z:");
            z = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"X: {x}\nY: {y}\nZ: {z}";
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }

        public void IncreaseByScalar(int num)
        {

        }

        public void ReductionByScalar(int num)
        {
        }

        public Vector Addition(Vector v)
        {
            Vector result = new Vector();

            result.x = this.x + v.x;
            result.y = this.y + v.y;
            result.z = this.z + v.z;

            return result;
        }

        public Vector Substraction(Vector v)
        {
            Vector result = new Vector();

            result.x = this.x - v.x;
            result.y = this.y - v.y;
            result.z = this.z - v.z;

            return result;
        }

        public Vector ElementMultiply(Vector v)
        {
            Vector result = new Vector();

            result.x = this.x * v.x;
            result.y = this.y * v.y;
            result.z = this.z * v.z;

            return result;
        }

        public int ScalarMultiply(Vector v)
        {
            return this.x * v.x + this.y + v.y + this.z + v.z;
        }

        public double GetCosCorner(Vector v)
        {
            return this.ScalarMultiply(v) / (this.GetLength() * v.GetLength());
        }

        public bool EqualityTest(Vector v)
        {
            if (this.x == v.x && this.y == v.y && this.z == v.z) return true;
            else return false;
        }
    }
}
