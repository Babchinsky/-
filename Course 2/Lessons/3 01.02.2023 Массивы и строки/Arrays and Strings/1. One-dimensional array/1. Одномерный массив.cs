using System;

namespace CSharpApplication.one_dimensional_array
{
    class MainClass
    {
        static void Main()
        {
            // создание массива из 10 элементов типа int
            // все элементы массива инициализируются нулями
            int[] intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("{0,4}", intArray[i]);
            }
            Console.WriteLine();
            
            // создание + инициализация
            int[] intArray2 = new int[] { 1, 2, 3, 4 };
            for (int i = 0; i < intArray2.Length; i++)
            {
                Console.Write("{0,4}", intArray2[i]);
            }
            Console.WriteLine();
            
            // создание + инициализация (укороченный вариант)
            int[] arr2 = { 0, 3, 7, 17, 25 };
            // Можно объявить массив без инициализации
            int[] arr3;
            // Но его нельзя использовать, пока он не создан с помощью оператора new
            /*
            arr3[0] = 0; // Ошибка компиляции
            arr3 = {0, 3, 7, 17, 25}; // Ошибка компиляции
            */
            arr3 = new int[] { 0, 3, 7, 17, 25 };
            arr3[0] = 10;
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("{0,4}", arr3[i]);
            }
            Console.WriteLine();

            // создание массива из 10 элементов типа string
            // все элементы массива инициализируются null,
            // т. к. string - ссылочный тип
            string[] stringArray = new string[10];
            string[] stringArray2 = new string[7] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            for (int i = 0; i < stringArray2.Length; i++)
            {
                Console.WriteLine(stringArray2[i]);
            }
        }
    }
}

