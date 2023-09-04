using System;
using System.Collections;
using System.Collections.Generic;

namespace _39b_hw_30._03._2023_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel travel = new Travel();
            Walker walker = new Walker();
            walker.SeeTheSights(travel);

            Console.Read();
        }
    }

    class Walker
    {
        public void SeeTheSights(Travel travel)
        {
            IWalkIterator iterator = travel.CreateNumerator();
            while (iterator.HasNext())
            {
                Walk book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }

    

   
    

}