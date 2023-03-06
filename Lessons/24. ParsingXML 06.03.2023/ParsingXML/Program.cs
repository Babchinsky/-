using System;
using System.Xml;

namespace ParsingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // создадим объект XmlDocument и загрузим в него xml-файл
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("../../persons.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        Console.WriteLine(attr.Value);
                }
                // обходим все дочерние узлы элемента person
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "company")
                    {
                        Console.WriteLine("Компания: {0}", childnode.FirstChild.Value);
                    }
                    if (childnode.Name == "age")
                    {
                        Console.WriteLine("Возраст: {0}", childnode.InnerText);
                    }
                }
                Console.WriteLine();
            }

            XmlDocument document = new XmlDocument();
            document.Load("../../data.xml");
            XmlNodeList list = document.GetElementsByTagName("book");
            foreach (XmlNode node in list)
            {
                Console.WriteLine(node.InnerText + "\n");
                Console.WriteLine(node.InnerXml + "\n");
            }

            XmlNodeList nodes = document.GetElementsByTagName("library");
            foreach (XmlNode node in nodes)
            {
                if (node.HasChildNodes)
                {
                    XmlNode childnode = node.FirstChild;
                    do
                    {
                        Console.WriteLine(childnode.InnerText + "\n");
                        Console.WriteLine(childnode.InnerXml + "\n");

                    } while ((childnode = childnode.NextSibling) != null);
                }

            }
            Console.Read();
        }
    }
}
