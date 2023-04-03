using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41b_hw_04._03._2023_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel travel = new Travel(new Bicycle());
            travel.Move();
            travel.Transport = new Bus();
            travel.Move();

            Console.ReadLine();
        }
    }
    abstract class Transport
    {
        public int Price { set; get; }
        public int Time { set; get; }
        //public Transport transport { get; internal set; }

        public abstract void Move();
    }

    class Bicycle : Transport
    {
        public Bicycle()
        {
            Price = 0;
            Time = 3;
        }
        public override void Move()
        {
            Console.WriteLine("Перемещение на велосипеде");
        }
    }

    class Bus : Transport
    {
        public Bus()
        {
            Price = 2;
            Time = 2;
        }
        public override void Move()
        {
            Console.WriteLine("Перемещение на автобусе");
        }
    }

    class Taxi : Transport
    {
        public Taxi()
        {
            Price = 3;
            Time = 1;
        }
        public override void Move()
        {
            Console.WriteLine("Перемещение на такси");
        }
    }

    class Travel
    {
        protected int price;
        protected int time;
        public Transport Transport { private get; set; }

        public Travel(Transport transport)
        {
            this.price = transport.Price;
            this.time = transport.Time;
            Transport = transport;
        }
       
        public void Move()
        {
            Transport.Move();
        }
    }
}
