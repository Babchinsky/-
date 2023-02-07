using System;

class Student
{
    static int counter = 0;
    public Student()
    {
        this.Code = ++counter;
    }

    public int Age { get; set; }

    // E��� � C# 5.0 ���������� ������� ������������ ��������� ��� ��������� ������ �� ������, 
    // �� ������� ������� private set.
    // public int Code { get; private set; }
    // � C# 6.0 ������������� ��������� private set
    public int Code { get; } // C# 6.0

    public string Name { get; set; }
    public string Surname { get; set; }
    public double Average { get; set; }
}

class Person
{
    public string Name { get; set; } = "����";
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
            Console.WriteLine("������� ���: ");
            st[i].Name = Console.ReadLine();
            Console.WriteLine("������� �������: ");
            st[i].Surname = Console.ReadLine();
            Console.WriteLine("������� �������: ");
            st[i].Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("������� ������� ����: ");
            st[i].Average = Convert.ToDouble(Console.ReadLine());
            //st[i].Code = 100; // �������� Code ������ ��� ������
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
