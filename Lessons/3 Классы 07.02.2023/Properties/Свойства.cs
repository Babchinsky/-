using System;

class Student 
{
	int age;
	string name;
	string surname;
    int id_code;
    double avg;

    static int counter = 0;
    public Student()
    {
        this.id_code = ++counter;
    }

    public int Age 
    {
        get{
            return age;
        }
        set{
            if (value > 0)
                age = value;
            }
    }

    public int Code
    {
        get
        {
            return id_code;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            if (value != "")
                name = value;
        }
    }

    public string Surname 
    {
        get
        {
            return surname;
        }
        set
        {
            if (value != "")
                surname = value;
        }
    }

    public double Average
    {
        get
        {
            return avg;
        }
        set
        {
            if (value >= 0 && value <= 12)
                avg = value;
        }
    }
}

class MainClass {
	static void Main ()
    {
        Student []st = new Student[2];
        for (int i = 0; i < st.Length; i++)
        {
            st[i] = new Student();
            Console.WriteLine("¬ведите им€: ");
            st[i].Name = Console.ReadLine();
            Console.WriteLine("¬ведите фамилию: ");
            st[i].Surname = Console.ReadLine();
            Console.WriteLine("¬ведите возраст: ");
            st[i].Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¬ведите средний балл: ");
            st[i].Average = Convert.ToDouble(Console.ReadLine());
            // st[i].Code = 100; // свойство Code только дл€ чтени€
        }
        for (int i = 0; i < st.Length; i++)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", st[i].Code, st[i].Name, st[i].Surname, st[i].Age, st[i].Average);
        }
	}
}
