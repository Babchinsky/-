using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_hw_abstract_factory_21._03._2023
{
    interface IContinent
    {
        IContinent CreateAfrica();
        IContinent CreateNorthAmerica();
    }

    class Continent : IContinent
    {
        public IContinent CreateAfrica() => new Africa();

        public IContinent CreateNorthAmerica() => new NorthAmerica();
    }
}
