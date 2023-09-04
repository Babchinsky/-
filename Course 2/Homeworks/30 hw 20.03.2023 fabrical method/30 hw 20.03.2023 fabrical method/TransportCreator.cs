using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_hw_20._03._2023_fabrical_method
{
    abstract class TransportCreator
    {
        public abstract ITransport Create();
        public abstract ITransport Create(double fuelConsumption, double costOfDelivery, double distance);
        public abstract void Deliver();
    }


    class ShipCreator : TransportCreator
    {
        public override ITransport Create()
        {
            return new Ship();
        }

        public override ITransport Create(double fuelConsumption, double costOfDelivery, double distance)
        {
            return new Ship(fuelConsumption, costOfDelivery, distance);
        }
        public override void Deliver()
        {
            Console.WriteLine("Доставка судном");
        }
    }

    class TruckCreator : TransportCreator
    {
        public override ITransport Create()
        {
            return new Truck();
        }

        public override ITransport Create(double fuelConsumption, double costOfDelivery, double distance)
        {
            return new Truck(fuelConsumption, costOfDelivery, distance);
        }
        public override void Deliver()
        {
            Console.WriteLine("Доставка грузовиком");
        }
    }

    class PlaneCreator : TransportCreator
    {
        public override ITransport Create()
        {
            return new Plane();
        }

        public override ITransport Create(double fuelConsumption, double costOfDelivery, double distance)
        {
            return new Plane(fuelConsumption, costOfDelivery, distance);
        }

        public override void Deliver()
        {
            Console.WriteLine("Доставка самолётом");
        }
    }
}
