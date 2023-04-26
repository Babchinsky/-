using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _19_hw_26._04._2023_MVC.Model
{
    class Database
    {
        List<Book> books = new List<Book>();

        public Database()
        {
            // Загружаем XML-документ из файла
            XmlDocument doc = new XmlDocument();
            doc.Load("books.xml");

            // Получаем список элементов <book>
            XmlNodeList booksXml = doc.GetElementsByTagName("book");

            // Перебираем элементы <book> и добавляем информацию о каждой книге в словарь
            foreach (XmlNode book in booksXml)
            {
                // Получаем значения элементов <title> и <author>
                string title = book.SelectSingleNode("title").InnerText;
                string author = book.SelectSingleNode("author").InnerText;

                // Добавляем информацию о книге в cписок
                books.Add(new Book(title, author));
            }
        }

        public List<Book> FindByTitle(string bookTitle)
        {
            List<Book> result = new List<Book>();

            foreach (Book f in books)
            {
                if (f.Name.Contains(bookTitle))
                {
                    result.Add(f);
                }
            }


            if (result.Count > 0)
            {
                return result;
            }
            else return null;
        }
        public List<Book> FindByAuthor(string bookAuthor)
        {
            List<Book> result = new List<Book>();

            foreach (Book f in books)
            {
                if (f.Author.Contains(bookAuthor))
                {
                    result.Add(f);
                }
            }

            if (result.Count > 0)
            {
                return result;
            }
            else return null;
        }
    }
}
