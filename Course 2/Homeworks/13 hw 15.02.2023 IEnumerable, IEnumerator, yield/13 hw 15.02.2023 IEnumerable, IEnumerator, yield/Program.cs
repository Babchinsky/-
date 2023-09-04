using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_hw_15._02._2023_IEnumerable__IEnumerator__yield
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book[] books = new Book[3];


            books[0] = new Book("Something", "cfasadfas", 2003, "Something", "Something");
            books[1] = new Book("Easy", "Aasf", 1955, "Easy", "Easy");
            books[2] = new Book("Test", "Bfasdf", 2023, "Test", "Test");

            //foreach (Book book in books)
            //{
            //    Console.WriteLine(book);
            //    Console.WriteLine();
            //}

            //////Array.Sort(books);

            //Array.Sort(books, new Book.SortByYear());



            //foreach (Book book in books)
            //{
            //    Console.WriteLine(book);
            //    Console.WriteLine();
            //}
            Library l1 = new Library(books);
            //l1.ShowBooks();

            foreach (Book book in l1) 
            {
                book.Show();
            }
        }
    }
}
