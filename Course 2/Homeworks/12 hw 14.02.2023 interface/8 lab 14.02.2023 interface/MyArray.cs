using _8_lab_14._02._2023_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_hw_14._02._2023_interface
{
    internal class MyArray : IOutput, IMath, ISort, ICalc, IOutput2, ICalc2
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

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el < valueToCompare) count++;
            }
            if (count != 0) return count;
            return 0;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el > valueToCompare) count++;
            }
            if (count != 0) return count;
            return 0;
        }

        public void ShowEven()
        {
            foreach (int el in arr)
            {
                if (el % 2 == 0) Console.Write(el + " "); 
            }
        }

        public void ShowOdd()
        {
            foreach (int el in arr)
            {
                if (el % 2 != 0) Console.Write(el + " ");
            }
        }

        public int CountDistinct()
        {
            List<int> uniqueValues = new List<int>();
            for (int i = 0; i < arr.Length; ++i)
            {
                if (!uniqueValues.Contains(arr[i]))
                    uniqueValues.Add(arr[i]);
            }
            int numberOfElements = uniqueValues.Count;
            return numberOfElements;
        }
        
        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (int el in arr)
            {
                if (el == valueToCompare) count++;
            }
            return count;
        }
    }
}
