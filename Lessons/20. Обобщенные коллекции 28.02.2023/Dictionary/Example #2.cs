using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(1, "Ukraine");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(4, "France");
            countries.Add(5, "Germany");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();
            // получение элемента по ключу
            string country = countries[4];
            // изменение объекта
            countries[4] = "Spain";
            // удаление по ключу
            countries.Remove(2);

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();

            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('b', new Person() { Name = "Bill" });
            people['t'] = new Person() { Name = "Tom" };
            people.Add('j', new Person() { Name = "John" });

            foreach (KeyValuePair<char, Person> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            // перебор ключей
            foreach (char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            // перебор по значениям
            foreach (Person p in people.Values)
            {
                Console.WriteLine(p.Name);
            }
        }
    }

    class Person
    {
        public string Name {get; set;}
    }
}