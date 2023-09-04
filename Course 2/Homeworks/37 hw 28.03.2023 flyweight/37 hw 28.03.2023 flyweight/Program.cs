using System;

namespace _37_hw_28._03._2023_flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            LightInfantry a = new LightInfantry();
            TransportVehicles b = new TransportVehicles();
            HeavyGroundCombatEquipment c = new HeavyGroundCombatEquipment();
            Factory factory = new Factory();

            factory.Show(a, 75, 85);


            Console.WriteLine();
            Console.WriteLine();

            factory.Show(b, 95, 35);

            Console.WriteLine();
            Console.WriteLine();

            factory.ShowAll();
        }
    }
}