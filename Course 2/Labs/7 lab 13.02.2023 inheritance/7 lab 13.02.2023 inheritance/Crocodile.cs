using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Crocodile : Animal
    {
        private string Species { get; set; }

        public Crocodile(string name, int weight, string continent, string species) : base(name, weight, continent)
        {
            Species = species;
        }
        public override string ToString()
        {
            return base.ToString() + $"Species: {Species}\n";
        }
    }
}
