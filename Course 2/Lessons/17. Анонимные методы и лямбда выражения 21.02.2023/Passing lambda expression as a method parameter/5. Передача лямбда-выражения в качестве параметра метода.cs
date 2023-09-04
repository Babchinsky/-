using System;

namespace Anonymous_methods
{
    class MainClass
    {
        delegate bool IsEqual(int x);

        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // найдем сумму чисел больше 5
            int result = Sum(integers, y => y > 5);
            Console.WriteLine("Сумма чисел больше 5: " + result);

            result = Sum(integers, delegate(int x) 
            {
                if(x>5)
                {
                    return true;
                }
                return false;
            });

            // найдем сумму четных чисел
            result = Sum(integers, x => x % 2 == 0);
            Console.WriteLine("Сумма чётных чисел: " + result);
            // сумма элементов от 1 до 4
            result = Sum(integers, x => (x > 1 && x <= 4));
        }
        private static int Sum(int[] numbers, IsEqual func)
        {
            int result = 0;
            foreach (int i in numbers)
            {
                if (func(i))
                    result += i;
            }
            return result;
        }
    }
}


