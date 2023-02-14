using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    internal class Student: Human
    {
        public string University { get; set; }

        public Student(string name, int age, string university ):base(name,age)
        {
            University = university;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"University:  {University}\n");
        }

    public override string ToString()
        {
            return base.ToString() + $"University:  {University}\n";
        }
    }
}
