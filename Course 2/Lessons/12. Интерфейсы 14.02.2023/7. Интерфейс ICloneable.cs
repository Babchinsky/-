﻿// Клонирование объектов. Реализация глубокого копирования 

using System;

class Club : ICloneable
{
    public string Name { get; set; }
    public string City { get; set; }
    public Coach Coach { get; set; }

    public Club(string name, string city, string coach)
    {
        this.Name = name;
        this.City = city;
        this.Coach = new Coach();
        this.Coach.Name = coach;
    }
    public Club() : this("Динамо", "Киев", "Александр Хацкевич") { }
    public void Show()
    {
        Console.WriteLine("\n{0}, {1}, {2}", Name, City, Coach.Name);
    }
    public object Clone()
    {
        return new Club(Name, City, Coach.Name);
    }

    //public object Clone()
    //{
    //    return this.MemberwiseClone(); // Поверхностное копирование
    //}
}

class Coach
{
    public string Name { get; set; }
}

class MainClass
{
    public static void Main()
    {
        Club c = new Club();
        c.Show();
        Club c2 = c; // обе ссылки указывают на один и тот же объект
        c2.Name = "Манчестер Юнайтед";
        c2.City = "Манчестер";
        c2.Coach.Name = "Жозе Моуринью";
        c.Show();

        Club c3 = c.Clone() as Club; // две независимые копии
        c3.Name = "Черноморец";
        c3.City = "Одесса";
        c3.Coach.Name = "Олег Дулуб";
        c3.Show();
        c.Show();
    }
}
