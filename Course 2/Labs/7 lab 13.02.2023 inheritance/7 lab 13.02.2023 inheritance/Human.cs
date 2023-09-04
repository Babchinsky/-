using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human() :this("Human", 0) { }
        public Human(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public virtual void Print()
        {
            //Console.WriteLine("Human Print");
            Console.WriteLine($"Name: {Name}\nAge: {Age}");
        }

        public override string ToString() 
        {
            return $"Name: {Name}\nAge: {Age}\n";
        }
    }
}
