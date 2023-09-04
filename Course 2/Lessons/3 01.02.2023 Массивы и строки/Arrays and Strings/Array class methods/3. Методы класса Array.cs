using System;

namespace CSharpApplication.methodsOfArray
{
    class MainClass
    {
        static void Main()
        {
            int[] ar = new int[10];
            Random rnd = new Random();
            Console.WriteLine("»сходный целочисленный массив: ");
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rnd.Next(-20, 20);
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();

            int number, position;
            Console.WriteLine("¬ведите число дл€ поиска: ");
            number = Convert.ToInt32(Console.ReadLine());
            position = Array.IndexOf(ar, number); // поиск первого вхождени€ числа в массив
            if (position >= 0)
                Console.WriteLine("ѕервое вхождение введенного числа найдено в позиции " + position);
            else
                Console.WriteLine("“акого числа нет в массиве!");
            Console.WriteLine();

            Console.WriteLine("¬ведите число дл€ поиска: ");
            number = Convert.ToInt32(Console.ReadLine());
            position = Array.LastIndexOf(ar, number); // поиск последнего вхождени€ числа в массив
            if (position >= 0)
                Console.WriteLine("ѕоследнее вхождение введенного числа найдено в позиции " + position);
            else
                Console.WriteLine("“акого числа нет в массиве!");
            Console.WriteLine();

            Console.WriteLine("ћассив, отсортированный по возрастанию: ");
            Array.Sort(ar); // сортировка по возрастанию
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write("{0,4}", ar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("¬ведите число дл€ поиска: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("»скомое число находитс€ в массиве на " + Array.BinarySearch(ar, number) + " позиции");
            Console.WriteLine();

            Console.WriteLine("ћассив, отсортированный по убыванию: ");
            Array.Reverse(ar); // сортировка по убыванию
            foreach (int n in ar)
                Console.Write("{0,4}", n); // переменна€ n доступна только дл€ чтени€
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("»сходный вещественный массив: ");
            double[] doubleArr = new double[10];
            for (int i = 0; i < doubleArr.Length; i++)
            {
                doubleArr[i] = rnd.NextDouble() * 100;
                Console.Write("{0:F3}\t", doubleArr[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("—копированный вещественный массив: ");
            double[] doubleArr2 = new double[10];
            Array.Copy(doubleArr, doubleArr2, doubleArr.Length);
            foreach (double n in doubleArr2)
                Console.Write("{0:F3}\t", n); // переменна€ n доступна только дл€ чтени€
            Console.WriteLine();
            Console.WriteLine();

            Array.Clear(doubleArr, 0, doubleArr.Length); // обнуление массива
            foreach (double n in doubleArr)
                Console.Write("{0,4}", n); // переменна€ n доступна только дл€ чтени€
            Console.WriteLine();

        }
    }
}

