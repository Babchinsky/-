using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_Animal_world__abstract_factory__21._03._2023
{
    // Клиентский код работает с фабриками и продуктами только через абстрактные
    // типы: Абстрактная Фабрика и Абстрактный Продукт. Это позволяет передавать
    // любой подкласс фабрики или продукта клиентскому коду, не нарушая его.
    class AnimalWorld
    {
        public void Main()
        {
            // Клиентский код может работать с любым конкретным классом фабрики.
            Console.WriteLine("AnimalWorld: Testing client code with Africa (the first factory type)...");
            ClientMethod(new Africa());
            Console.WriteLine();

            Console.WriteLine("AnimalWorld: Testing the same client code with North America (the second factory type)...");
            ClientMethod(new NorthAmerica());
        }

        public void ClientMethod(IContinent continent)
        {
            var herbivore = continent.CreateHerbivore();
            var carnivore = continent.CreateCarnivore();

            herbivore.EatGrass();
            carnivore.Eat(herbivore);
        }
    }
}
