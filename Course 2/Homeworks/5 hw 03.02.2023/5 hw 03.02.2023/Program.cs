using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _5_hw_03._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task_8_StringBuilder();
            Task_8_String();
            Task_9();
            Task_10_StringBuilder();
            Task_10_String();
            Task_11();
            Task_12();
            Task_13_StringBuilder();
            Task_13_String();
            Task_14();
            Task_15();
        }

        public static void Task_8_StringBuilder()
        {
            Console.WriteLine("\n\t\tTask 8 String");
            StringBuilder text = new StringBuilder("Hello World! What's up?");
            Console.WriteLine(text);

            Console.Write("Enter index to delete it: ");
            int index = Convert.ToInt32(Console.ReadLine());
            index--;

            text.Remove(index, 1);

            Console.WriteLine(text);
        }
        public static void Task_8_String()
        {
            Console.WriteLine("\n\t\tTask 8 String");
            string text = "Hello World! What's up?";
            Console.WriteLine(text);

            Console.Write("Enter index to delete it: ");
            int index = Convert.ToInt32(Console.ReadLine());
            index--;

            text = text.Remove(index, 1);

            Console.WriteLine(text);
        }
        public static void Task_9()
        {
            Console.WriteLine("\n\t\tTask 9");
            string text = "Hello World! What's up?";
            Console.WriteLine(text);

            Console.Write("Enter symbol to delete it: ");
            char ch = Convert.ToChar(Console.ReadLine());


            while (text.Contains(ch) == true)
            {
                text = text.Remove(text.IndexOf(ch), 1);    
            }
            

            Console.WriteLine(text);
        }
        public static void Task_10_StringBuilder()
        {
            Console.WriteLine("\n\t\tTask 10 StringBuilder");
            StringBuilder text = new StringBuilder("Hello World! What's up?");
            Console.WriteLine(text);

            Console.Write("Enter symbol to add it in string: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter index to add in it: ");
            int index = Convert.ToInt32(Console.ReadLine());
            index--;

            text.Insert(index, ch);
            Console.WriteLine(text);
        }
        public static void Task_10_String()
        {
            Console.WriteLine("\n\t\tTask 10 String");
            string text = "Hello World! What's up?";
            Console.WriteLine(text);

            Console.Write("Enter symbol to add it in string: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter index to add in it: ");
            int index = Convert.ToInt32(Console.ReadLine());
            index--;

            text = text.Substring(0, index) + ch + text.Substring(index);
            Console.WriteLine(text);
        }
        public static void Task_11()
        {
            Console.WriteLine("\n\t\tTask 11");
            Console.WriteLine("Enter a string to check if it is a  pallindrome:");
            string text = Console.ReadLine();
            Console.WriteLine(text);

            string reverse_text = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse_text += text[i].ToString();
            }

            if (reverse_text == text) Console.WriteLine("String is Palindrome");
            else Console.WriteLine("String is not Palindrome");
        }
        public static void Task_12()
        {
            Console.WriteLine("\n\t\tTask 12");
            Console.WriteLine("Enter a string to count number of words:");
            string text = Console.ReadLine();
            Console.WriteLine(text);

            int number_of_words = 0;

            char[] delimiters = new char[] { ' ', '\r', '\n' };
            number_of_words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine($"Number of words: {number_of_words}");
        }
        public static void Task_13_StringBuilder()
        {
            Console.WriteLine("\n\t\tTask 13 StringBuilder");
            Console.WriteLine("Enter a string:");
            StringBuilder text = new StringBuilder(Console.ReadLine());

            Console.WriteLine("Enter a substring which you want to replace:");
            string replaced_substr = Console.ReadLine();

            Console.WriteLine("Enter a new substring to replace:");
            string new_substr = Console.ReadLine();

            text.Replace(replaced_substr, new_substr);

            Console.WriteLine(text);
        }
        public static void Task_13_String()
        {
            Console.WriteLine("\n\t\tTask 13 String");
            Console.WriteLine("Enter a string:");
            string text = Console.ReadLine();

            Console.WriteLine("Enter a substring which you want to replace:");
            string replaced_substr = Console.ReadLine();

            Console.WriteLine("Enter a new substring to replace:");
            string new_substr = Console.ReadLine();

            text = text.Replace(replaced_substr, new_substr);

            Console.WriteLine(text);
        }
        public static void Task_14()
        {
            Console.WriteLine("\n\t\tTask 14");

            Console.WriteLine("Enter the string:");
            string text = Console.ReadLine();
            string[] wordsArr = text.Split(' ');
            Array.Reverse(wordsArr);

            string reverse_text = String.Join(" ", wordsArr);
            Console.WriteLine(reverse_text);
        }
        public static void Task_15()
        {
            Console.WriteLine("\n\t\tTask 15");

            Console.WriteLine("Enter the string:");
            string text = Console.ReadLine();
            string[] words_arr = text.Split(' ');

            int number_of_vovel_words = 0;

            char[] vowels = { 'у', 'е', 'ё', 'ы', 'а', 'о', 'э', 'я', 'и', 'ю' };

            foreach(string word in words_arr)
            {
                if (vowels.Contains(word[word.Length - 1]) == true) number_of_vovel_words++;
            }

            Console.WriteLine("Numbers of words ending in vowels: " + number_of_vovel_words);

        }
    }
}
