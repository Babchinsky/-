using System;
using System.IO;
using System.Xml;

namespace ReadingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // XmlTextReader - предоставляет средство чтения, обеспечивающее быстрый прямой доступ к данным XML.
            XmlTextReader reader = new XmlTextReader("../../persons.xml");
            string str = null;
            while (reader.Read()) // Считывает следующий узел из потока
            {
                if (reader.NodeType == XmlNodeType.Text)
                    str += reader.Value + "\n";

                // NodeType возвращает тип текущего узла
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.HasAttributes)// имеются ли атрибуты?
                    {
                        while (reader.MoveToNextAttribute()) // Перемещается к следующему атрибуту
                        {
                            // Value - значение узла
                            str += reader.Value + "\n";
                        }
                    }
                }
            }
            Console.WriteLine(str);
            reader.Close();
        }
    }
}
