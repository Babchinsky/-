using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw_10._05._2023_dll
{
    public abstract class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    namespace MyStudent
    {
        public class Student : Person
        {
            public string Academy { get; set; }
            public Student() { }
            public Student(string name, int age, string academy) : base(name, age) 
            {
                Academy = academy;
            }

        }
    }
}
