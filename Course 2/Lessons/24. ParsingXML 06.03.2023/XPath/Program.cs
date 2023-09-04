using System;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;

namespace XPath
{
    class Program
    {
        private static void ValidationCallback(object sender, ValidationEventArgs args)
        {
             Console.WriteLine(args.Message);
        }

        static void Main(string[] args)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load("../../persons.xml");

                XmlElement xRoot = xDoc.DocumentElement;

                // SelectNodes выбирает все объекты XmlNode, соответствующие выражению XPath
                // Выбор всех дочерних узлов корневого элемента
                XmlNodeList list = xRoot.SelectNodes("*");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.OuterXml);
                Console.WriteLine("\n\n");

                // Выбор всех значений атрибутов name у элементов person
                list = xRoot.SelectNodes("person");
                foreach (XmlNode n in list)
                    // SelectSingleNode выбирает первый объект XmlNode, соответствующий выражению XPath
                    Console.WriteLine(n.SelectSingleNode("@name").Value);
                Console.WriteLine("\n\n");

                // Выбор узла, у которого атрибут name имеет значение Ларри Пейдж
                XmlNode node = xRoot.SelectSingleNode("person[@name='Ларри Пейдж']");
                if (node != null)
                    Console.WriteLine(node.OuterXml);
                Console.WriteLine("\n\n");

                // Выбор узла, у которого вложенный элемент company имеет значение Microsoft
                node = xRoot.SelectSingleNode("person[company='Microsoft']");
                if (node != null)
                    Console.WriteLine(node.OuterXml);
                Console.WriteLine("\n\n");

                // Выбор всех компаний
                list = xRoot.SelectNodes("child::person/child::company");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.InnerText);
                Console.WriteLine("\n\n");

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.DtdProcessing = DtdProcessing.Parse;
                settings.ValidationType = ValidationType.DTD;
                settings.ValidationEventHandler += ValidationCallback;

                XmlReader reader = XmlReader.Create("../../Clubs.xml", settings);
                xDoc = new XmlDocument();
                xDoc.Load(reader);
                xRoot = xDoc.DocumentElement;

                node = xRoot.SelectSingleNode("child::club[2]");
                Console.WriteLine(node.InnerText);
                Console.WriteLine("\n\n");

                list = xRoot.SelectNodes("child::club[2]/attribute::node()");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.Value);
                Console.WriteLine("\n\n");

                node = node.SelectSingleNode("following-sibling::*");
                Console.WriteLine(node.OuterXml);
                Console.WriteLine("\n\n");

                XmlNode parent = node.SelectSingleNode("parent::*");
                Console.WriteLine(parent.Name);
                Console.WriteLine("\n\n");

                node = node.FirstChild;
                list = node.SelectNodes("ancestor::*");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.Name);
                Console.WriteLine("\n\n");

                list = xRoot.SelectNodes("descendant::node()");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.OuterXml);
                Console.WriteLine("\n\n");

                list = xRoot.SelectNodes("descendant::text()");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.OuterXml);
                Console.WriteLine("\n\n");

                list = xRoot.SelectNodes("descendant::*");
                foreach (XmlNode n in list)
                    Console.WriteLine(n.OuterXml);
                Console.WriteLine("\n\n");

                list = xRoot.SelectNodes("child::club[*='Динамо']");
                foreach (XmlNode xmlnode in list)
                {
                    Console.WriteLine(xmlnode.OuterXml);
                }
                Console.WriteLine("\n\n");

                list = xRoot.SelectNodes("child::club[@country='Украина']");
                foreach (XmlNode xmlnode in list)
                {
                    Console.WriteLine(xmlnode.OuterXml);
                }
                Console.WriteLine("\n\n");
                reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
