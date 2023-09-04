using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_Animal_world__abstract_factory__21._03._2023
{
    //public interface IHerbivore
    //{
    //    string UsefulFunctionA();
    //}

    // Каждый отдельный продукт семейства продуктов должен иметь базовый
    // интерфейс. Все вариации продукта должны реализовывать этот интерфейс.
    public abstract class Herbivore
    {
        public double weight;
        public bool life = true;

        public Herbivore(double weight) => this.weight = weight;
        public abstract void EatGrass();
    }


    // Конкретные продукты создаются соответствующими Конкретными Фабриками.
    class Wildebeest : Herbivore
    {
        public Wildebeest(double weight) : base(weight)
        {
        }

        public override void EatGrass()
        {
            Console.WriteLine("Антилопа ест траву");
        }
    }

    class Bison : Herbivore
    {
        public Bison(double weight) : base(weight)
        {
        }

        public override void EatGrass()
        {
            Console.WriteLine("Бизон ест траву");
        }
    }
}
