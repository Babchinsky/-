using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_abstract_factory_21._03._2023
{
    class NorthAmerica
    {
        public Herbivore CreateHerbivore(double weight)
        {
            return new Wildbeest(weight);
        }
        public Carnivore CreateCarnivore(double power)
        {
            return new Wolf(power);
        }
    }

}
