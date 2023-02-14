﻿// Существует возможность «научить» класс сортироваться по определённому критерию 
// Для этого необходимо отнаследовать класс от интерфейса IComparer

using System;
using System.Collections;

public class Club
{
    string name;
    string city;
    public Club(string name, string city)
    {
        this.name = name;
        this.city = city;
    }
    public Club() : this("Динамо", "Киев") { }
    public void Show()
    {
        Console.WriteLine("\n{0}   {1}", name, city);
    }
    public class SortByName : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            if (obj1 is Club && obj2 is Club)
                return (obj1 as Club).name.CompareTo((obj2 as Club).name);

            throw new NotImplementedException();
        }
    }
    public class SortByCity : IComparer
    {
        int IComparer.Compare(object obj1, object obj2)
        {
            if (obj1 is Club && obj2 is Club)
                return (obj1 as Club).city.CompareTo((obj2 as Club).city);

            throw new NotImplementedException();
        }
    }
}

class MainClass
{
    public static void Main()
    {
        Club[] c = new Club[6];
        Console.WriteLine("Неупорядоченный массив:");
        c[0] = new Club("Динамо", "Киев");
        c[1] = new Club("Арсенал", "Лондон");
        c[2] = new Club("Интер", "Милан");
        c[3] = new Club("Бавария", "Мюнхен");
        c[4] = new Club("Челси", "Лондон");
        c[5] = new Club("Реал", "Мадрид");
        foreach (Club temp in c)
            temp.Show();
        Array.Sort(c, new Club.SortByName());
        Console.WriteLine("\nМассив, упорядоченный по имени:");
        foreach (Club temp in c)
            temp.Show();
        Array.Sort(c, new Club.SortByCity());
        Console.WriteLine("\nМассив, упорядоченный по городу:");
        foreach (Club temp in c)
            temp.Show();
    }
}

