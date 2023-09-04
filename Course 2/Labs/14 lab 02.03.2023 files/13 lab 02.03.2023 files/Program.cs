using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace _13_lab_02._03._2023_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            Task_5();
        }


        static bool IsFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (b < n)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == n;
        }
        static void Task_1()
        {
            Random random = new Random();
            int[] ints = new int[100];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(0, 100);
                //Console.Write(ints[i] + " ");
            }

            StreamWriter sw = new StreamWriter("Prime.txt", true);
            int j;


            //Iterate through the items of array
            for (int i = 0; i < ints.Length; i++)
            {

                // see if num is evenly divisible
                for (j = 2; j < ints[i]; j++)
                    if ((ints[i] % j == 0))
                    {
                        // num is evenly divisible -- not prime
                        //Console.WriteLine("{0} : Is NOT a primenumber", +ints[i]);
                        break;
                    }
                if (j == ints[i])
                {
                    //Console.WriteLine("{0} : Is a primenumber", +ints[i]);
                    sw.Write(ints[i] + " ");
                }

            }

            sw.Close();
            StreamWriter sw2 = new StreamWriter("Fibonacci.txt", true);
            foreach (var item in ints)
            {
                if (IsFibonacci(item)) sw2.Write(item + " ");
            }
            sw2.Close();
        }

        static void Task_2()
        {
            Console.Write("Введите имя файла: ");
            string filename = Console.ReadLine();



            Console.Write("Введите слово для поиска: ");
            string searchWord = Console.ReadLine();

            Console.Write("Введите слово для замены: ");
            string replaceWord = Console.ReadLine();

            int count = 0;

            try
            {
                string content = File.ReadAllText(filename);
                Console.WriteLine(content);
                content = content.Replace(searchWord, replaceWord);
                File.WriteAllText(filename, content);

                string[] words = content.Split(new char[] { '.',' ',','});

                foreach (string word in words)
                {
                    if (word == replaceWord) count++;
                }

                Console.WriteLine($"Слово \"{searchWord}\" заменено на \"{replaceWord}\" {count} раз.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void Task_3()
        {
            string moderate = File.ReadAllText("Moderate.txt");
            string content = File.ReadAllText("Task3.txt");
            string[] moderate_words = moderate.Split(new char[] { ' ' });


            foreach (string word in moderate_words) 
            {
                content = content.Replace(word, wordToStars(word));
            }
            File.WriteAllText("Task3.txt", content);
        }
        static string wordToStars(string word)
        {
            string buf = string.Empty;

            while (buf.Length < word.Length)
            {
                buf += '*';
            }
            return buf;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Task_4()
        {
            string content = File.ReadAllText("Task4.txt");
            
            File.WriteAllText("Task4.txt", Reverse(content));
        }

        static void Task_5()
        {
            //for (int i = 0;i < 100000; i++)
            //{
            //    File.AppendAllText("Task5.txt", i.ToString() + " ");
            //}

            int positiveNumbersCount = 0;
            int negativeNumbersCount = 0;
            int twoDigitNumbersCount = 0;
            int fiveDigitNumbersCount = 0;

            string content = File.ReadAllText("Task5.txt");
            string[] strNums = content.Split(' ');

            foreach (string num in strNums)
            {
                int number = int.Parse(num);

                if (number > 0)
                {
                    positiveNumbersCount++;
                    // записываем положительное число в соответствующий файл
                    using (StreamWriter sw = new StreamWriter("positive.txt", true))
                    {
                        sw.WriteLine(number);
                    }
                }
                else if (number < 0)
                {
                    negativeNumbersCount++;
                    // записываем отрицательное число в соответствующий файл
                    using (StreamWriter sw = new StreamWriter("negative.txt", true))
                    {
                        sw.WriteLine(number);
                    }
                }

                if (number >= 10 && number <= 99)
                {
                    twoDigitNumbersCount++;
                }

                if (number >= 10000 && number <= 99999)
                {
                    fiveDigitNumbersCount++;
                }
            }

            Console.WriteLine($"Количество положительных чисел: {positiveNumbersCount}");
            Console.WriteLine($"Количество отрицательных чисел: {negativeNumbersCount}");
            Console.WriteLine($"Количество двузначных чисел: {twoDigitNumbersCount}");
            Console.WriteLine($"Количество пятизначных чисел: {fiveDigitNumbersCount}");
        }
    }
}
