using System;
namespace CSharp.AvgOfArray
{
    class Average
    {
        static void Main()
        {
            int count = 10;
            Console.WriteLine("Введите количество элементов массива");
            try
            {
                count = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "принимаем количество элементов = 10");
            }
            Random r = new Random();
            int[] a = new int[count];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(1, 20);
                Console.Write("{0,4}", a[i]);
            }

            Average.Avg(a);
            Console.WriteLine("\nСреднее значение = {0}", Avg(a));

        }
        public static double Avg(int[] a)
        {
            double average = 0;
            foreach (int i in a)
                average += i;
            return average / a.Length;
        }
    }
}