using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lab_10._02._2023_indexers
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

        public Matrix(Matrix obj)
        {
            this.arr = obj.arr;
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

        public int this[int i, int j]
        {
            get 
            {
                if (i < 0 || i > arr.GetLength(0)) throw new Exception("Некорректный индекс строки " + i);
                else if (j < 0 || j > arr.GetLength(1)) throw new Exception("Некорректный индекс столбца " + j);
                else return arr[i, j];
            }
            set
            {
                if (i < 0 || i > arr.GetLength(0)) throw new Exception("Некорректный индекс строки " + i);
                else if (j < 0 || j > arr.GetLength(1)) throw new Exception("Некорректный индекс столбца " + j);
                else arr[i, j] = value;
            }
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    if (a.arr[i, j] != b.arr[i, j]) return false;
                }
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            if (a == b) return false;
            else return true;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            try
            {
                if (a.arr.GetLength(0) != b.arr.GetLength(0) || a.arr.GetLength(1) != b.arr.GetLength(1))
                {
                    throw new Exception("Матрицы не одного размера");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return a;
            }

            Matrix result = new Matrix(a);

            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    result.arr[i, j] += b.arr[i, j];
                }
            }
            return a;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            try
            {
                if (a.arr.GetLength(0) != b.arr.GetLength(0) || a.arr.GetLength(1) != b.arr.GetLength(1))
                {
                    throw new Exception("Матрицы не одного размера");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return a;
            }

            Matrix result = new Matrix(a);

            for (int i = 0; i < a.arr.GetLength(0); i++)
            {
                for (int j = 0; j < a.arr.GetLength(1); j++)
                {
                    result.arr[i, j] -= b.arr[i, j];
                }
            }
            return a;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            try
            {
                if (a.arr.GetLength(1) != b.arr.GetLength(0))
                {
                    throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return a;
            }

            Matrix result = new Matrix();

            result.arr = new int[a.arr.GetLength(0), b.arr.GetLength(1)];

            for (var i = 0; i < a.arr.GetLength(0); i++)
            {
                for (var j = 0; j < b.arr.GetLength(1); j++)
                {
                    result.arr[i, j] = 0;

                    for (var k = 0; k < a.arr.GetLength(1); k++)
                    {
                        result.arr[i, j] += a.arr[i, k] * b.arr[k, j];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            string buf = string.Empty;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    buf += arr[i, j].ToString() + ' ';
                }
                buf += "\n";
            }

            return buf;
        }

    }
}
