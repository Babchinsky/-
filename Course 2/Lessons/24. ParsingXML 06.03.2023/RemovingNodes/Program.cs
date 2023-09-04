using System;
using System.Xml;

namespace RemovingNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../persons.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode firstNode = xRoot.FirstChild;
            xRoot.RemoveChild(firstNode);
            xDoc.Save("../../persons.xml");
            Console.WriteLine("XML-документ изменен!");
        }
    }
}
