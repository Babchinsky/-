using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_hw_20._03._2023_fabrical_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logistics logistics = new Logistics();
            TransportCreator truck1 = new TruckCreator();
            logistics.Create(truck1);

            TransportCreator ship1 = new ShipCreator();
            logistics.Create(ship1);

            TransportCreator plane1 = new PlaneCreator();
            logistics.Create(plane1);
        }
    }
}
