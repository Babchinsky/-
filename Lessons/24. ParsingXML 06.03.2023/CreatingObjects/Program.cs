using System;
using System.Xml;
using System.Collections.Generic;

namespace CreatingObjects
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../persons.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                Person user = new Person();
                XmlNode attr = xnode.Attributes.GetNamedItem("name");
                if (attr != null)
                    user.Name = attr.Value;

                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "company")
                        user.Company = childnode.InnerText;

                    if (childnode.Name == "age")
                        user.Age = Int32.Parse(childnode.InnerText);
                }
                persons.Add(user);
            }
            foreach (Person u in persons)
                Console.WriteLine("{0} ({1}) - {2}", u.Name, u.Company, u.Age);
            Console.Read();
        }
    }
}
