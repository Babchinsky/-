using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_06._02._2023
{
    internal class Matrix
    {
        private int[,] arr;

        public Matrix()
        {
            arr = null;
        }

        public Matrix(int[,] arr)
        {
            this.arr = arr;
        }

        public int GetMin()
        {
            int min = arr[0, 0];

            foreach (int element in arr) 
                if (element < min) min = element;

            return min;
        }

        public int GetMax()
        {
            int max = arr[0, 0];

            foreach (int element in arr)
                if (element > max) max = element;

            return max;
        }

        public int[,] Arr
        {
            get { return arr; }
            set { arr = value; }
        }
        
        public override string ToString()
        {
            string buf = string.Empty;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    buf+= arr[i, j].ToString() + ' ';
                }
                buf += "\n";
            }

            return buf;
        }

    }
}
