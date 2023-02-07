using System;

namespace private_set
{
    class Person 
    {
        // Eсли в C# 5.0 необходимо сделать автосвойство доступным для установки только из класса, 
        // то следует указать private set.
        public string Name { get; private set; } // C# 5.0
        public Person(string n)
        {
            Name = n;
        }
    }

    class Student 
    {
        // В C# 6.0 необязательно указывать private set
        public string Name { get; } // C# 6.0
        public Student(string n)
        {
            Name = n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван");
            // person.Name = "Иван"; // свойство только для чтения
            Console.WriteLine(person.Name);
            Student student = new Student("Петр");
            // student.Name = "Петр"; // свойство только для чтения
            Console.WriteLine(student.Name);
            Console.WriteLine(nameof(student.Name));
        }
    }
}
