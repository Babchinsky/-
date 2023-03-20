using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_hw_20._03._2023_fabrical_method
{
    interface ITransport
    {
        void Deliver();
        double FuelConsumption { get; set; }
        double CostOfDelivery { get; set; }
        double Distance { get; set; }
    }

    class Truck : ITransport
    {
        public Truck() { }
        public Truck(double fuelConsumption, double costOfDelivery, double distance)
        {
            FuelConsumption = fuelConsumption;
            CostOfDelivery = costOfDelivery;
            Distance = distance;
        }
        public double CostOfDelivery { get; set; }

        public double Distance { get; set; }

        public double FuelConsumption { get; set; }

        public void Deliver()
        {
            Console.WriteLine("Доставка грузовиком");
        }
    }
    class Ship : ITransport
    {
        public Ship() { }
        public Ship(double fuelConsumption, double costOfDelivery, double distance)
        {
            FuelConsumption = fuelConsumption;
            CostOfDelivery = costOfDelivery;
            Distance = distance;
        }

        public double FuelConsumption { get; set; }
        public double CostOfDelivery { get; set; }
        public double Distance { get; set; }

        public void Deliver()
        {
            Console.WriteLine("Доставка судном");
        }
    }
    class Plane : ITransport
    {
        public Plane() { }
        public Plane(double fuelConsumption, double costOfDelivery, double distance)
        {
            FuelConsumption = fuelConsumption;
            CostOfDelivery = costOfDelivery;
            Distance = distance;
        }

        public double FuelConsumption { get; set; }
        public double CostOfDelivery { get; set; }
        public double Distance { get; set; }

        public void Deliver()
        {
            Console.WriteLine("Доставка самолётом");
        }
    }
}
