using System;
using System.IO;
using System.Text;
using System.Xml;

namespace WritingXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // XmlTextWriter представляет средство записи, предоставляющее способ быстрого прямого создания XML-файлов 
            XmlTextWriter xmlwriter = new XmlTextWriter("../../Clubs.xml", Encoding.UTF8);
            xmlwriter.WriteStartDocument();// Записывает объявление XML с номером версии 1.0
            // Formatting определяет способ форматирования выходных данных
            xmlwriter.Formatting = Formatting.Indented; //Форматирует отступы в дочерних элементах в соответствии с параметрами настройки IndentChar и Indentation
            xmlwriter.IndentChar = '\t'; // Возвращает или задает знак для отступа
            xmlwriter.Indentation = 1; // Возвращает или задает количество записываемых IndentChars для каждого уровня в иерархии
            xmlwriter.WriteStartElement("football"); // Записывает указанный открывающий тег
            xmlwriter.WriteComment("Футбольный клуб"); // Создает комментарий
            xmlwriter.WriteStartElement("club"); 
            xmlwriter.WriteStartAttribute("city", null); // Записывает атрибут с заданным именем
            xmlwriter.WriteString("Киев"); // Записывает заданное текстовое содержимое атрибута
            xmlwriter.WriteEndAttribute(); // Закрывает атрибут
            xmlwriter.WriteStartAttribute("country", null); 
            xmlwriter.WriteString("Украина"); 
            xmlwriter.WriteEndAttribute();
            xmlwriter.WriteString("Динамо"); // Записывает заданное текстовое содержимое элемента
            xmlwriter.WriteEndElement(); // Закрывает один элемент
            xmlwriter.WriteEndElement(); 
            Console.WriteLine("Данные сохранены в XML-файл");
            xmlwriter.Close();
        }
    }
}
