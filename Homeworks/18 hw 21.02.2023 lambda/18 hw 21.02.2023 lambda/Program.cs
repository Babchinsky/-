using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _18_hw_21._02._2023_lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            Task_4();
            //Task_5();
            //Task_6();
        }

        delegate (int, int, int) Get(Color color);
        static void Task_1()
        {
            Color color1 = Color.FromName("Blue");

            Get RGB = delegate (Color color)
            {
                return (color.R, color.G, color.B);
            };

            Console.WriteLine(RGB(color1));
        }
        static void Task_2()
        {
            Backpack backpack = new Backpack
            {
                Color = "Blue",
                Manufacturer = "Acme",
                Material = "Nylon",
                Weight = 1.2,
                Capacity = 10.0
            };
            //void DisplayMessage(string message) => Console.WriteLine(message);
            //backpack.Notify += DisplayMessage;
            backpack.Notify += (item) => Console.WriteLine($"Added item {item.Name} ({item.Volume} litres) to the backpack.");

            Item book = new Item { Name = "Book", Volume = 3.5 };
            backpack.AddItem(book);

            Item laptop = new Item { Name = "Laptop", Volume = 6.5 };
            backpack.AddItem(laptop);

            Item waterBottle = new Item { Name = "Water Bottle", Volume = 1.0 };

            try
            {
                backpack.AddItem(waterBottle); // генерирует исключение
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }

            Console.WriteLine(backpack);

        }
        static void Task_3()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int count = numbers.Count(num => num % 7 == 0);
            
            Console.WriteLine(count);
        }
        static void Task_4()
        {
            int[] numbers = { -1, -2, 3, -4, 5, -6, 7};


            int count = numbers.Count(num => num  > 0);
            
            Console.WriteLine(count);
        }
        static void Task_5()
        {
            int[] numbers = { -2, 5, 7, -2, -4, 7, -1 };

            var uniqueNegativeNumbers = numbers.Where(n => n < 0).Distinct();

            foreach (var number in uniqueNegativeNumbers)
            {
                Console.WriteLine(number);
            }
        }
        static void Task_6()
        {
            string text = "The quick brown fox jumps over the lazy dog";
            string wordToFind = "fox";

            bool containsWord = text.Split(' ').Any(word => word.ToLower() == wordToFind.ToLower());

            if (containsWord)
            {
                Console.WriteLine($"The text contains the word '{wordToFind}'.");
            }
            else
            {
                Console.WriteLine($"The text does not contain the word '{wordToFind}'.");
            }
        }
    }
}
