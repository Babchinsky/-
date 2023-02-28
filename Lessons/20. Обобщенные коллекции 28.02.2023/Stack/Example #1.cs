using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var MyStack = new Stack<char>();
            MyStack.Push('A');
            MyStack.Push('N');
            MyStack.Push('X');

            Console.WriteLine("Исходный стек: ");
            foreach (char s in MyStack)
                Console.Write(s);
            Console.WriteLine("\n");

            while (MyStack.Count > 0)
            {
                Console.WriteLine("Pop -> {0}", MyStack.Pop());
            }

            if (MyStack.Count == 0)
                Console.WriteLine("\nСтек пуст!");

        }
    }
}