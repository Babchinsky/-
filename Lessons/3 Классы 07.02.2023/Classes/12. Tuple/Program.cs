using System;

namespace Tuple
{
    // Для того, чтобы использовать кортеж, необходимо добавить в проект специальный пакет nuget: System.ValueTuple.
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (7, 10);
            Console.WriteLine(tuple.Item1); 
            Console.WriteLine(tuple.Item2); 
            tuple.Item1 += 15;

            (string, string, int) person = ("Petr", "Petrov", 20);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

            var student = (Name: "Ivan", Surname: "Ivanov", Age:25, Rating: 11.5);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Rating);

            var (Name, Age) = ("Vasya", 18);
            Console.WriteLine(Name);
            Console.WriteLine(Age);

            var range = (min: 0, max: 20);
            int[] ar = new int[10];
            var result = GetValues(ar, range);
            Console.WriteLine("Сумма элементов массива: " + result.sum);
            Console.WriteLine("Среднее арифметическое элементов массива: " + result.average);
        }

        private static (int sum, double average) GetValues(int [] ar, (int min, int max) range)
        {
            var rand = new Random();
            for (int i = 0; i < ar.Length; i++)
                ar[i] = rand.Next(range.min, range.max);
            var result = (sum: 0, average: 0.0);
            foreach(var item in ar)
            {
                result.sum += item;
            }
            result.average = result.sum / (double) ar.Length;
            return result;
        }
    }
}
