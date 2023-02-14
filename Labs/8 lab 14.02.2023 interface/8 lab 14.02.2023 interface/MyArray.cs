using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lab_14._02._2023_interface
{
    internal class MyArray : IOutput, IMath, ISort
    {
        int[] arr;

        public int this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = value;
            }
        }

        public MyArray(){}
        public MyArray(int[] arr)
        {
            this.arr = arr;
        }
        public void Show() 
        {
            foreach (int el in arr)
            {
                Console.Write(el + " ");
            }
        }
        public void Show(string info)
        {
            this.Show();
            Console.WriteLine(info);
        }

        public int Max()
        {
            int max = arr[0];

            foreach (int el in arr)
            {
                if (el > max) max = el;
            }
            return max;
        }

        public int Min()
        {
            int min = arr[0];

            foreach (int el in arr)
            {
                if (el < min) min = el;
            }
            return min;
        }

        public float Avg()
        {
            int sum = 0;
            foreach (int el in arr)
            {
                sum += el;
            }

            float avg = sum / arr.Length;
            return avg;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int el in arr)
            {
                if (el == valueToSearch) return true;
            }
            return false;
        }

        public void SortAsc()
        {
            Array.Sort(arr);
        }

        public void SortDesc()
        {
            SortAsc();
            Array.Reverse(arr);
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc == true) SortAsc();
            else SortDesc();
        }
    }
}
