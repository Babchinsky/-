using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Anonymous_methods
{
    // Лямбда-выражения представляют упрощенную запись анонимных методов. 
    // Лямбда-выражения позволяют создать емкие лаконичные методы, 
    // которые могут возвращать некоторое значение, и которые можно передать 
    // в качестве параметров в другие методы.
       
    delegate void MyDelegate(int[] arr);
    class MainClass
    {
      public static void Main()
        {
            int[] mass = new int[5];
            MyDelegate Init = (int[] arr) =>
            {
                for(int i=0;i<arr.Length;i++)
                {
                    arr[i] = i + 1;
                }
            };
            MyDelegate Print = (int[] arr) =>
            {
               foreach(int a in arr)
                {
                    Console.Write(a + "\t");
                }
                Console.WriteLine();
            };

            Init(mass);
            Print(mass);
         
        }
    }
}


