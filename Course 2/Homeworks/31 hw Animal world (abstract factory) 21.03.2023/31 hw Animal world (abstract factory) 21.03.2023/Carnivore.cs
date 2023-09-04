using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_Animal_world__abstract_factory__21._03._2023
{

    //public interface ICarnivore
    //{
    //    // Продукт B способен работать самостоятельно...
    //    string UsefulFunctionB();

    //    // ...а также взаимодействовать с Продуктами А той же вариации.
    //    //
    //    // Абстрактная Фабрика гарантирует, что все продукты, которые она
    //    // создает, имеют одинаковую вариацию и, следовательно, совместимы.
    //    string AnotherUsefulFunctionB(IHerbivore collaborator);
    //}

    // Базовый интерфейс другого продукта. Все продукты могут взаимодействовать
    // друг с другом, но правильное взаимодействие возможно только между
    // продуктами одной и той же конкретной вариации.
    public abstract class Carnivore
    {
        public double power;

        public Carnivore(double power) => this.power = power;
        public abstract void Eat(Herbivore herbivore);
    }

    // Конкретные Продукты создаются соответствующими Конкретными Фабриками.
    class Wolf : Carnivore
    {
        public Wolf(double power) :base(power) { }

        // Продукт B1 может корректно работать только с Продуктом A1. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта А в
        // качестве аргумента.
        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.life)
            {
                Console.WriteLine("Добыча уже съедена");
                return;
            }
            else
            {
                if (herbivore.weight > power) Console.WriteLine("Добыча слишком велика для волка");
                else
                {
                    herbivore.life = false;
                    Console.WriteLine("Волк съел добычу");
                }
            }
        }
    }

    class Lion : Carnivore
    {
        public Lion(double power) : base(power) { }

        // Продукт B1 может корректно работать только с Продуктом A1. Тем не
        // менее, он принимает любой экземпляр Абстрактного Продукта А в
        // качестве аргумента.
        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.life)
            {
                Console.WriteLine("Добыча уже съедена");
                return;
            }
            else
            {
                if (herbivore.weight > power) Console.WriteLine("Добыча слишком велика для льва");
                else
                {
                    herbivore.life = false;
                    Console.WriteLine("Лев съел добычу");
                }
            }
        }
    }
}
