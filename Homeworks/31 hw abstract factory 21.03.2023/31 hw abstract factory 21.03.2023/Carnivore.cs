using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_abstract_factory_21._03._2023
{
    abstract class Carnivore
    {
        public double power;
        public Carnivore() { }
        public Carnivore(double power) => this.power = power;

        public abstract void Eat(Herbivore herbivore);
    }

    class Wolf : Carnivore
    {
        public Wolf(double power) : base(power) { }

        public override void Eat(Herbivore herbivore)
        {
            if (this.power >= herbivore.weight) 
            {
                herbivore.life = false;
                Console.WriteLine("Волк ест добычу");
            }
            else
            {
                Console.WriteLine("Добыча слишком велика для волка");
            }
        }
        public override string ToString()
        {
            return $"Волк - {power}";
        }
    }

    class Lion : Carnivore
    {
        public Lion(double power) : base(power) { }

        public override void Eat(Herbivore herbivore)
        {
            if (this.power >= herbivore.weight)
            {
                herbivore.life = false;
                Console.WriteLine("Лев ест добычу");
            }
            else
            {
                Console.WriteLine("Добыча слишком велика для льва");
            }
        }

        public override string ToString()
        {
            return $"Лев - {power}";
        }
    }
}
