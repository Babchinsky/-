using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_lesson_01._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = new int[10];
            int Min = 1;
            int Max = 20;
            Random randNum = new Random();

            for (int i = 0; i < iArr.Length; i++)
                iArr[i] = randNum.Next(Min, Max);
            
            foreach (int element in iArr)
                Console.Write("{0, 4}",element);

        }
    }
}
