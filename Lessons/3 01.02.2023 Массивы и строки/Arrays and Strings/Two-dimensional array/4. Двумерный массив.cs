using System;

namespace CSharpApplication.two_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            // создание двумерного массива из 5x5 элементов типа int
            // все элементы массива инициализируются нулями
            int[,] intArray = new int[5, 5];
            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Console.Write("{0,4}", intArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // создание + инициализация массива 3x2
            int[,] intArray2 = new int[3, 2] { { 0, 3 }, { 7, 17 }, { 25, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,4}", intArray2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // создание + инициализация (укороченный вариант)
            int[, ,] intArray3 = { { { 0, 3 }, { 7, 17 } }, { { 25, 0 }, { 0, 3 } }, { { 7, 17 }, { 25, 0 } } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        Console.Write("{0,4}", intArray3[i, j, k]);
                    }
                }
            }
            // Можно объявить массив без инициализации
            int[,] arr3;
            // Но его нельзя использовать, пока он не создан с помощью оператора new
            /*
            arr3[0,0] = 0; // Ошибка компиляции
            arr3 = { {0, 3}, {7, 17}, {25, 0} }; // Ошибка компиляции
            */
            arr3 = new int[,] { { 0, 3 }, { 7, 17 }, { 25, 0 } };
            arr3[0, 0] = 10;

        }
    }
}

