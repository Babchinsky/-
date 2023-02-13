using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human() : this("Human", 0)
        {

        }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print()
        {
            Console.Write($"Name: {Name}\tAge: {Age}\t");
        }

    public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\t";
        }
    }
}
