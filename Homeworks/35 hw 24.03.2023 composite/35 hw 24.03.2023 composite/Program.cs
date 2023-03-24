﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_hw_24._03._2023_composite
{

    class Program
    {
        static void Main(string[] args)
        {
             Client client = new Client();
            client.Main();
        }
    }


    class Client
    {
        public void Main()
        {
            //Component office = new Room("Office");
            ////Component leaf = new Item("Leaf");
            //Room reception = new Room("Reception");
            ////office.Add(leaf);
            //office.Add(reception);
            //office.Display();

            Composite office = new Composite("Офис");
            Composite recepiton = new Composite("Приёмная");

            recepiton.Add(new Leaf("Тёплые тона", 50));
            recepiton.Add(new Leaf("Компьютер", 30));
            office.Add(recepiton);

            Composite room1 = new Composite("Комната 1");
            room1.Add(new Leaf("Стол", 20));
            office.Add(room1);


            office.Display();
        }
    }
    abstract class Component
    {
        protected string name;
        public int price;

        public Component(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract int GetPrice();
    }
    class Composite : Component
    {
        List<Component> children = new List<Component>();

        public Composite(string name) : base(name, 0) { }
        public Composite(string name, int price)
            : base(name, price)
        { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }

        public override void Display()
        {
            Console.WriteLine(name + " " + this.GetPrice());

            foreach (Component component in children)
            {
                component.Display();
            }
        }
        public override int GetPrice()
        {
            int sum = 0;

            foreach (Component component in children)
            {
                sum += component.GetPrice();
            }
            return sum;
        }
    }
    class Leaf : Component
    {
        public Leaf(string name, int price)
            : base(name, price)
        { }

        public override void Display()
        {
            Console.WriteLine("\t" + name + " " + price);
        }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }

        public override int GetPrice()
        {
            return price;
        }
    }
}
