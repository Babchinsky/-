using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_abstract_factory_21._03._2023
{
    class AnimalWorld
    {
        public IContinent continent;

        public AnimalWorld() { }
        public AnimalWorld(IContinent continent) => this.continent = continent;
        
        public void MealsHerbivores()
        {

        }
        public void NutritionCarnivores()
        {

        }
    }
}
