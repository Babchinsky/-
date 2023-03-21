using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_Animal_world__abstract_factory__21._03._2023
{
    // Интерфейс Абстрактной Фабрики объявляет набор методов, которые возвращают
    // различные абстрактные продукты.  Эти продукты называются семейством и
    // связаны темой или концепцией высокого уровня. Продукты одного семейства
    // обычно могут взаимодействовать между собой. Семейство продуктов может
    // иметь несколько вариаций,  но продукты одной вариации несовместимы с
    // продуктами другой.
    public interface IContinent
    {
        Herbivore CreateHerbivore();

        Carnivore CreateCarnivore();
    }

    // Конкретная Фабрика производит семейство продуктов одной вариации. Фабрика
    // гарантирует совместимость полученных продуктов.  Обратите внимание, что
    // сигнатуры методов Конкретной Фабрики возвращают абстрактный продукт, в то
    // время как внутри метода создается экземпляр  конкретного продукта.
    class Africa : IContinent
    {
        public Herbivore CreateHerbivore()
        {
            return new Wildebeest(50);
        }

        public Carnivore CreateCarnivore()
        {
            return new Wolf(50);
        }
    }

    // Каждая Конкретная Фабрика имеет соответствующую вариацию продукта.
    class NorthAmerica : IContinent
    {
        public Herbivore CreateHerbivore()
        {
            return new Bison(50);
        }

        public Carnivore CreateCarnivore()
        {
            return new Lion(50);
        }
    }
}
