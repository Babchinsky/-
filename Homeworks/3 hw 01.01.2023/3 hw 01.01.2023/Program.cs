using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_hw_01._01._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_1();
            //Task_2();
            //Task_3();
            //Task_4();
            //Task_5();
            //Task_6();
            Task_7();
        }
        public static void Task_1()
        {
            Console.WriteLine("\n\n\t\t\tTask 1");
            int[] A = new int[5];
            double[,] B = new double[3, 4];




            Console.WriteLine("\t\t\t1D Array A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(i + 1 + ": ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            double max = A[0];
            double min = A[0];
            double sum = 0;
            double product = 1;

            int sum_of_even_A = 0;
            double sum_of_odd_col_el_B = 0;


            foreach (int element in A)
            {
                Console.Write(element + " ");
                if (element % 2 == 0) sum_of_even_A += element;
                if (element > max) max = element;
                if (element < min) min = element;
                sum += element;
                product *= element;
            }


            Console.WriteLine("\n\t\t\t2D Array B");
            Random rand = new Random();

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.NextDouble();

                    if (j % 2 == 1) sum_of_odd_col_el_B += B[i, j];
                    if (B[i, j] > max) max = B[i, j];
                    if (B[i, j] < min) min = B[i, j];
                    sum += B[i, j];
                    product *= B[i, j];

                    Console.Write($"{B[i, j]:F2}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum: {sum}\nProduct: {product}\nMax: {max}\nMin: {min}\nSum of even in A: {sum_of_even_A}\nSum of odd cols in B: {sum_of_odd_col_el_B}");
        }
        public static void Task_2()
        {
            Console.WriteLine("\n\n\t\t\tTask 2");
            int[,] arr2D = new int[5, 5];

            Random random = new Random();
            int min = arr2D[0, 0];
            int max = arr2D[0, 0];
            int sum_between = 0;

            // Вывод в консоль и поиск минимума/максимума
            for (int i = 0; i < arr2D.GetLength(0); i++)
            {
                for (int j = 0; j < arr2D.GetLength(1); j++)
                {
                    arr2D[i, j] = random.Next(-100, 100);
                    Console.Write("{0, 4}", arr2D[i, j]);

                    if (arr2D[i, j] < min) min = arr2D[i, j];
                    if (arr2D[i, j] > max) max = arr2D[i, j];
                }
                Console.WriteLine();
            }

            // Подсчёт суммы между минимумом и максимумом
            bool flag = false;

            // Проходим двумерный массив как одномерный
            foreach (int element2D in arr2D)
            {
                if (element2D == min || element2D == max) // Если встречаем мин или макс, то меняем флаг на противоположный
                {
                    flag = !flag;
                    if (flag == true) continue;           // Если флаг правда, то пропускаем конец итерации, чтобы не тронуть первое значение, а сумма была строго МЕЖДУ
                }

                if (flag == true) sum_between += element2D;
            }


            Console.WriteLine($"Sum between {min} and {max}: {sum_between}");
        }
        public static void Task_3()
        {
            Console.WriteLine("\n\n\t\t\tTask 3");
            Console.WriteLine("Enter a string:");
            string text = Console.ReadLine();
            int shift = 3;


            // Шифрование
            string encrypted_text = String.Empty;
            int index_encrypted_text = 0;

            foreach (char ch in text)
            {
                encrypted_text = encrypted_text.Insert(index_encrypted_text++, Convert.ToChar(ch + shift).ToString());
            }

            Console.WriteLine("Encrypted text: " + encrypted_text);

            // Расшифрование
            string decrypted_text = String.Empty;
            int index_decrypted_text = 0;

            foreach (char ch in encrypted_text)
            {
                decrypted_text = decrypted_text.Insert(index_decrypted_text++, Convert.ToChar(ch - shift).ToString());
            }
            Console.WriteLine("Decrypted text: " + decrypted_text);
        }
        public static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4");

            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C = new int[3, 3];
            int[,] D = new int[3, 3];

            int num = 7;

            Random rand = new Random();

            Console.WriteLine("Matrix A");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rand.Next(1, 10);
                    Console.Write("{0, 3}", A[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix A x " + num);
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] *= 7;
                    Console.Write("{0, 3}", A[i, j]);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Matrix B");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = rand.Next(1, 10);
                    Console.Write("{0, 3}", B[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Matrix C = A + B");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write("{0, 3}", C[i, j]);
                }
                Console.WriteLine();
            }



            Console.WriteLine("Matrix D = A * B");
            int[,] c = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        c[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
                Console.WriteLine();
            }



        }
        public static void Task_5()
        {
            Console.WriteLine("\n\n\t\t\tTask 5");
            Console.WriteLine("Enter an arithmetic sentence(2 + or - 4): ");
            string expression = "42 - 45 = ";

            string[] temp = expression.Split();
            int result = 0;

            if (temp.Contains("+")) 
            { 
                result = int.Parse(temp[0]) + int.Parse(temp[2]);
            }

            else if (temp.Contains("-"))
            {
                result = int.Parse(temp[0]) - int.Parse(temp[2]);
            }


            Console.WriteLine(expression + result);
        }
        public static void Task_6()
        {
            Console.WriteLine("\n\n\t\t\tTask 6");
            string text = "«today is a good day for walking. i will try to walk near the sea»";
            char[] chars = text.ToCharArray();
            char[] delimeters = { ' ', '\n', '\r' };
            
            for (int i = 0; i < chars.Length - 2; i++)
            {
                if (chars[i] == '.' && delimeters.Contains(chars[i + 1]) && Char.IsLetter(chars[i + 2]))
                    chars[i + 2] = Char.ToUpper(chars[i + 2]);
            
                else if (i == 0 && Char.IsLetter(chars[i])) 
                    chars[i] = Char.ToUpper(chars[i]);

                else if (chars[i] == '«' && Char.IsLetter(chars[i + 1]))
                    chars[i + 1] = Char.ToUpper(chars[i + 1]);
            }

            Console.WriteLine(text);
            Console.WriteLine(chars);

        }
        public static void Task_7()
        {
            Console.WriteLine("\n\n\t\t\tTask 7");

            string text = "To be, or not to be, that is the question,\r\nWhether 'tis nobler in the mind to suffer\r\nThe slings and arrows of outrageous fortune,\r\nOr to take arms against a sea of troubles,\r\nAnd by opposing end them? To die: to sleep;\r\nNo more; and by a sleep to say we end\r\nThe heart-ache and the thousand natural shocks\r\nThat flesh is heir to, 'tis a consummation\r\nDevoutly to be wish'd. To die, to sleep";
            char[] delimiters = { ' ', '\r', '.', ',', '!', '?', '\"', '\'', '\n', ':', ';' };
            Console.WriteLine(text);

            string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;


            

            foreach (string word in words)
            {
                if (word == "die") counter++;
            }    

            string result = text.Replace("die", "***");

            Console.WriteLine();
            Console.WriteLine("Number of bad words: " + counter);
            Console.WriteLine(result);
        }
    }
}
