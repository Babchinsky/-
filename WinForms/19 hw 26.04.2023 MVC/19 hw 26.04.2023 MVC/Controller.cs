using _19_hw_26._04._2023_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_hw_26._04._2023_MVC
{
    class Controller
    {
        public List<Book> GetBookByTitle(string bookTitle)
        {
            Database db = new Database();
            List<Book> rez = db.FindByTitle(bookTitle);

            if (rez != null)
            {
                return rez;
            }
            return new List<Book>();
        }

        public List<Book> GetBookByAuthor(string bookAuthor)
        {
            Database db = new Database();
            List<Book> rez = db.FindByAuthor(bookAuthor);

            if (rez != null)
            {
                return rez;
            }
            return new List<Book>();
        }
    }
}
