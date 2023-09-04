using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Sailor : Human
    {
        public int Salary { get; set; }

        public Sailor(string name, int age, int salary) : base(name, age)
        {
            Salary = salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Salary: " + Salary + '\n');
        }
        public override string ToString()
        {
            return base.ToString() + $"Salary: {Salary}\n";
        }
    }
}
