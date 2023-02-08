using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_hw_08._02._2023_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_3();
            Task_4();
        }

        static void Task_3()
        {
            Console.WriteLine("\n\n\t\t\tTask 3");
            Passport first = new Passport();
            first.Init();
            Console.WriteLine(first);
        }

        static void Task_4()
        {
            Console.WriteLine("\n\n\t\t\tTask 4");
            Console.Write("Enter an  expression: ");

            
            bool result = false;


            try
            {
                string expression = Console.ReadLine();
                string[] temp = expression.Split();

                if (temp.Length != 3) throw new Exception("Вы ввели больше трёх аргументов");




                if (temp.Contains(">"))
                {
                    if (int.Parse(temp[0]) > int.Parse(temp[2])) result = true;
                    else result = false;
                }
                else if (temp.Contains("<"))
                {
                    if (int.Parse(temp[0]) < int.Parse(temp[2])) result = true;
                    else result = false;
                }
                else if (temp.Contains(">="))
                {
                    if (int.Parse(temp[0]) >= int.Parse(temp[2])) result = true;
                    else result = false;
                }
                else if (temp.Contains("<="))
                {
                    if (int.Parse(temp[0]) <= int.Parse(temp[2])) result = true;
                    else result = false;
                }
                else if (temp.Contains("=="))
                {
                    if (int.Parse(temp[0]) == int.Parse(temp[2])) result = true;
                    else result = false;
                }
                else if (temp.Contains("!="))
                {
                    if (int.Parse(temp[0]) != int.Parse(temp[2])) result = true;
                    else result = false;
                }

                if (result == true) Console.WriteLine(expression + " = True");
                else Console.WriteLine(expression + " = False");
            } 
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
            }



            

        }
    }
}
