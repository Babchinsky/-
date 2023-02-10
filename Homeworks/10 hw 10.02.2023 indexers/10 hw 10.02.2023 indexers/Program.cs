using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_hw_10._02._2023_indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book a = new Book("Easy", "Easy", 2000, "Easy", "Easy");
            Book b = new Book("Example", "Example", 2010, "Example", "Example");

            ListOfBooks l1 = new ListOfBooks(a, b);
            //Console.WriteLine(l1);
            //Console.WriteLine(l1[1]);

            Book c = new Book("Test", "Test", 1111, "Test", "Test");
            ListOfBooks l2 = l1 + c;

            l2 -= 2;
            Console.WriteLine(l2);

            Book d = new Book("Test", "Test", 1111, "Test", "Test");
            if (l2.IsThereOn(d) == true) Console.WriteLine("True");
            else Console.WriteLine("False");



            //ListOfBooks l3 = new ListOfBooks(4);
            //Console.WriteLine(l3);


        }
    }
}
// У меня есть 3 класса: класс Program, класс Book, класс ListOfBooks.
// Я хочу, чтобы в списке книг у меня был доступ к свойствам в классе книги.
// Но закрыть доступ к этим свойствам в главном классе.

// Пока что они все в одном пространстве имён.