using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_abstract_factory_21._03._2023
{
    abstract class Herbivore
    {
        public double weight;
        public bool life = true;

        public Herbivore() { }
        public Herbivore(double weight)
        {
            this.weight = weight;
        }
        public abstract void EatGrass();
    }

    class Wildbeest : Herbivore
    {
        public Wildbeest(double weight) :base(weight) { }

        public override void EatGrass()
        {
            Console.WriteLine("Антилопа ест траву");
        }
        public override string ToString()
        {
            if (life) return $"Антилопа - {weight} - Живая";
            else return $"Антилопа - {weight} - Съедена";
        }
    }

    class Bison : Herbivore
    {
        public Bison(double weight) : base(weight) { }
        public override void EatGrass()
        {
            Console.WriteLine("Бизон ест траву");
        }
        public override string ToString()
        {
            if (life) return $"Бизон - {weight} - Живой";
            else return $"Бизон - {weight} - Съеден";
        }
    }
}
