using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_hw_23._03._2023_Prototype
{
    interface IClone
    {
        Transport Clone();
    }

    class Engine
    {
        int enginePower;         // мощность
        double engineCapacity;   // объём
        string fuelType;         // тип топлива
        double fuelConsumption;  // расход топлива

        public Engine(int enginePower, double engineCapacity, string fuelType, double fuelConsumption)
        {
            this.enginePower = enginePower;
            this.engineCapacity = engineCapacity;
            this.fuelType = fuelType;
            this.fuelConsumption = fuelConsumption;
        }

        public override string ToString()
        {
            return $"Engine Power: {enginePower}\nEngine Capacity: {engineCapacity}\nFuel Type: {fuelType}\nFuel Consumption: {fuelConsumption}";
        }
    }

    abstract class Transport : IClone
    {
        protected string name;
        protected int year;
        protected Engine engine;

        public Transport() { }

        public Transport(string name, int year, Engine engine)
        {
            this.name = name;
            this.year = year;
            this.engine = engine;
        }

        public Transport(Transport transport)
        {
            this.name = transport.name;
            this.year = transport.year;
            this.engine = transport.engine;
        }

        abstract public Transport Clone();
        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}\nYear: {year}\n{engine}");
        }
    }

    class Truck : Transport
    {
        public Truck(string name, int year, Engine engine) : base(name, year, engine) { }
        public Truck(Truck truck) : base(truck) { }

        public override Transport Clone()
        {
            return new Truck(this);
        }
    }

    class Ship : Transport
    {
        public Ship(string name, int year, Engine engine) : base(name, year, engine) { }
        public Ship(Ship ship) : base(ship) { }

        public override Transport Clone()
        {
            return new Ship(this);
        }
    }

    class Plane : Transport
    {
        public Plane(string name, int year, Engine engine) : base(name, year, engine) { }
        public Plane(Plane plane) : base(plane) { }

        public override Transport Clone()
        {
            return new Plane(this);
        }
    }
}
