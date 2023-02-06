using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_hw_02._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
        }

        public static void Task_1()
        {
            Console.WriteLine("\n\n\t\t\tTask 1");
            int[][] arr = new int[5][];

            Random rand = new Random();

            int min_elements_in_row = 5;
            int max_elements_in_row = 0;
            int index_longest_row = 0;
            int index_shortest_row = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                // случайное количество столбцов
                arr[i] = new int[rand.Next(2, 8)];

                // узнаём индексы самых длинных и самых коротких строк
                if (arr[i].Length > max_elements_in_row)
                {
                    max_elements_in_row = arr[i].Length;
                    index_longest_row = i;
                }

                if (arr[i].Length < min_elements_in_row)
                {
                    min_elements_in_row = arr[i].Length;
                    index_shortest_row = i;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(1, 100);
                    Console.Write("{0, 4}", arr[i][j]);
                }
                Console.WriteLine();
                
            }

            int[][] arr_result = new int[arr.Length][];

            arr_result[index_longest_row] = new int[arr[index_shortest_row].Length];
            arr_result[index_shortest_row] = new int[arr[index_longest_row].Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i != index_longest_row && i != index_shortest_row)
                { 
                    arr_result[i] = new int[arr[i].Length];
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr_result[i][j] = arr[i][j];
                    }
                }
            }

            Console.WriteLine("Index longest: " + index_longest_row);
            Console.WriteLine("Index shortest: " + index_shortest_row);

            for (int i = 0; i < arr_result[index_longest_row].Length; i++)
            {
                arr_result[index_longest_row][i] = arr[index_shortest_row][i];
            }

            for (int i = 0; i < arr_result[index_shortest_row].Length; i++)
            {
                arr_result[index_shortest_row][i] = arr[index_longest_row][i];
            }




            for (int i = 0; i < arr_result.Length; i++)
            {
                for (int j = 0; j < arr_result[i].Length; j++)
                {
                    Console.Write("{0, 4}", arr_result[i][j]);
                }
                Console.WriteLine();
            }


        }
        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2");

            int[][] arr = new int[4][];
            arr[0] = new int[6];
            arr[1] = new int[5];
            arr[2] = new int[4];
            arr[3] = new int[2];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(1, 100);
                    Console.Write("{0, 4}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
