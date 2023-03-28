using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_hw_28._03._2023_flyweight
{
    internal class Factory
    {
        private List<Flyweight> flyweights = new List<Flyweight>();

        public void Show(Flyweight type, int x, int y)
        {
            if (!flyweights.Contains(type))
            {
                flyweights.Add(type);
                type.X = x;
                type.Y = y;
            }
            flyweights.Where(t => t == type).FirstOrDefault().Show(x, y);

            
        }
        public void ShowAll()
        {
            foreach (Flyweight type in flyweights)
            {
                Show(type, type.X, type.Y);
                Console.WriteLine();
            }
            
        }
    }
}
