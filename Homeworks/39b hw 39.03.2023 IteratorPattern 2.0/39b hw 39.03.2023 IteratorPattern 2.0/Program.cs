using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace _39b_hw_39._03._2023_IteratorPattern_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Клиентский код может знать или не знать о Конкретном Итераторе
            // или классах Коллекций, в зависимости от уровня косвенности,
            // который вы хотите сохранить в своей программе.
            var walks = new WalksCollection();


            Console.WriteLine("С начала алфавита:");

            foreach (var element in walks)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nС конца алфавита:");

            walks.ReverseDirection();

            foreach (var element in walks)
            {
                Console.WriteLine(element);
            }
        }
    }
}