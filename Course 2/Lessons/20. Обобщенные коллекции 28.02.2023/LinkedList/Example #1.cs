using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            // Создадим связный список
            LinkedList<string> link = new LinkedList<string>();

            // Добавим несколько элементов
            link.AddFirst("Украина");
            link.AddFirst("Австрия");
            link.AddFirst("Швейцария");
            link.AddFirst("Франция");

            // Отобразим элементы в прямом направлении
            LinkedListNode<string> node;
            Console.WriteLine("Элементы коллекции в прямом направлении: ");
            for (node = link.First; node != null; node = node.Next)
                Console.Write(node.Value + "\t");

            // Отобразить элементы в обратном направлении
            Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");
            for (node = link.Last; node != null; node = node.Previous)
                Console.Write(node.Value + "\t");

            Console.ReadLine();
        }
    }
}