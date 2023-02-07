using System;

namespace CSharpApplication.array
{
    class MainClass
    {
        static void Main()
        {
            // создание "зубчатого" массива из 3 элементов
            int [][] intArray = new int [3][];
            for(int i = 0; i < intArray.Length; i++)
               // каждый элемент содержит одномерный массив из 5 элементов
               intArray[i] = new int[5];

            // создание "зубчатого" непрямоугольного массива из 3 элементов
            float [][] floatArray = new float [3][];
            for(int i = 0; i < floatArray.Length; i++)
               // каждый элемент содержит одномерный массив из i + 1 элементов
               floatArray[i] = new float[i + 1];

            // Инициализация "зубчатых" массивов

            // вариант 1
            int [][] intArray2 = new int [3][];
            intArray2[0] = new int[] {1, 2, 3, 4, 5};
            intArray2[1] = new int[] {3, 4, 5};
            intArray2[2] = new int[] {1, 2, 3, 4, 5, 6, 7};
            for(int i = 0; i < intArray2.Length; i++)
            {
                for (int j = 0; j < intArray2[i].Length; j++)
                {
                    Console.Write("{0,4}", intArray2[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // вариант 2
            int[][] intArray3 = new int[][] 
            {
               new int[] {1, 2, 3, 4, 5},
               new int[] {3, 4, 5},
               new int[] {1, 2, 3, 4, 5, 6, 7}
            };

            // вариант 3
            int[][] intArray4 = 
            {
               new int[] {1, 2, 3, 4, 5},
               new int[] {3, 4, 5},
               new int[] {1, 2, 3, 4, 5, 6, 7}
            };

            // "зубчатые" и "обычные" массивы можно смешивать
            int [][,] myMixedArray = new int [][,] 
            {
               new int[,] { {1, 2}, {3, 4} },
               new int[,] { {5, 6}, {7, 8}, {9, 10} },
               new int[,] { {11, 12} } 
            };
            
            // Доступ к элементу массива
            System.Console.WriteLine(myMixedArray[0][0,0]); // отобразится 1

            // Можно объявить массив без инициализации
            int [][] arr3;
            // Но его нельзя использовать, пока он не создан с помощью оператора new

        }
    }
}

