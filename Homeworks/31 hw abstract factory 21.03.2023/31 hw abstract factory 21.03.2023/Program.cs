using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_abstract_factory_21._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Africa africa = new Africa();

            //Carnivore lion1 = africa.CreateCarnivore(123);
            //Herbivore wildbeest1 = africa.CreateHerbivore(123);

            //Console.WriteLine(lion1+ "\n" + wildbeest1);

            //wildbeest1.EatGrass();
            //lion1.Eat(wildbeest1);

            Continent continent1 = new Continent();

            Africa africa = continent1.CreateAfrica();

            
        }
    }
}
