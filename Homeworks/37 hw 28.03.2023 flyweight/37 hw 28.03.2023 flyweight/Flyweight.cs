using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_hw_28._03._2023_flyweight
{
    abstract class Flyweight
    {
        public string Picture { get; set; }
        public int MoveSpeed { get; set; }
        public int Power { get; set; }
        public int X { get; set; }
        public int Y { get; set; }


        public void Show(int x, int y)
        {
            Console.WriteLine($"Picture: {Picture}\nMove Speed: {MoveSpeed}\nPower: {Power}\nX: {x} Y: {y}");
        }
    }


    class LightInfantry : Flyweight
    {
        public LightInfantry()
        {
            Picture = "Легкая пехота";
            MoveSpeed = 20;
            Power = 10;
        }
    }

    class TransportVehicles : Flyweight
    {
        public TransportVehicles()
        {
            Picture = "Транспортные автомашины";
            MoveSpeed = 70;
            Power = 0;
        }
    }

    class HeavyGroundCombatEquipment : Flyweight
    {
        public HeavyGroundCombatEquipment()
        {
            Picture = "Тяжелая наземная боевая техника";
            MoveSpeed = 15;
            Power = 150;
        }
    }

    class LightGroundCombatEquipment : Flyweight
    {
        public LightGroundCombatEquipment()
        {
            Picture = "Легкая наземная боевая техника";
            MoveSpeed = 50;
            Power = 30;
        }
    }

    class Aircraft : Flyweight
    {
        public Aircraft()
        {
            Picture = "Авиатехника";
            MoveSpeed = 300;
            Power = 100;
        }
    }
}
