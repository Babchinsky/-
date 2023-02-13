using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Animal
    {
        private string Name { get; set; }
        private int Weight { get; set; }
        private string Continent { get; set; }

        public Animal() :this("Example", 0, "Africa"){ }
        public Animal(string name, int weight, string continent)
        {
            Name = name;
            Weight = weight;
            Continent = continent;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nWeight: {Weight}\nContinent: {Continent}\n";
        }
    }
}
