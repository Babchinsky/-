using System;
using System.Xml;

namespace recursive
{
    class Program
    {
        public static void Parse(XmlNode node)
        {
            if (node.NodeType == XmlNodeType.Element)
            {
                Console.Write("<" + node.Name);
                for (int i = 0; i < node.Attributes.Count; i++) 
                    Console.Write(" " + node.Attributes[i].Name + "=\"" + node.Attributes[i].Value + "\"");
                if (node.HasChildNodes)
                    Console.WriteLine(">");
                else
                    Console.WriteLine(" />");
                for (int i = 0; i < node.ChildNodes.Count; i++)
                    Parse(node.ChildNodes[i]);
                if (node.HasChildNodes)
                    Console.WriteLine("</" + node.Name + ">");
            }
            else if (node.NodeType == XmlNodeType.Text) 
                Console.WriteLine(node.Value);
        }

        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            Console.WriteLine("Введите путь к XML-документу: ");
            string path = Console.ReadLine();
            xDoc.Load(path);
            Console.WriteLine();
            XmlElement xRoot = xDoc.DocumentElement;
            Parse(xRoot);
        }
    }
}
