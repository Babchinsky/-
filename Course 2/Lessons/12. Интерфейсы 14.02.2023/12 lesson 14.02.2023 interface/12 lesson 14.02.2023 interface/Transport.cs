using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lesson_14._02._2023_interface
{
    internal abstract class Transport:IMove
    {
        public string Name { get; set; }

        public Transport(string name)
        {
            Name = name;
        }

        public abstract void Move();
        public abstract void Print();
    }

    class Camel : Transport
    {
        public Camel(string name):base(name) { }
        public override void Move()
        {
            Console.WriteLine("Move Camel");
        }

        public override void Print()
        {
            Console.WriteLine("Print Camel");
        }
    }

    class Airplane : Transport
    {
        public Airplane(string name) : base(name) { }
        public override void Move()
        {
            Console.WriteLine("Move Airplane");
        }

        public override void Print()
        {
            Console.WriteLine("Print Airplane");
        }
    }
}
