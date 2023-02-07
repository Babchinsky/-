using System;

class Student
{
    static int counter = 0;
    public Student()
    {
        this.Code = ++counter;
    }

    public int Age { get; set; }

    // Eсли в C# 5.0 необходимо сделать автосвойство доступным для установки только из класса, 
    // то следует указать private set.
    // public int Code { get; private set; }
    // В C# 6.0 необязательно указывать private set
    public int Code { get; } // C# 6.0

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Average { get; set; }
}

class Person
{
    public string Name { get; set; } = "Иван";
    public int Age { get; set; } = 25;
}

class MainClass
{
    static void Main()
    {
        Student[] st = new Student[2];
        for (int i = 0; i < st.Length; i++)
        {
            st[i] = new Student();
            Console.WriteLine("Введите имя: ");
            st[i].Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            st[i].Surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            st[i].Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите средний балл: ");
            st[i].Average = Convert.ToDouble(Console.ReadLine());
            //st[i].Code = 100; // свойство Code только для чтения
        }
        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", st[i].Code, st[i].Name, st[i].Surname, st[i].Age, st[i].Average);
        }

        Person person = new Person();
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}
