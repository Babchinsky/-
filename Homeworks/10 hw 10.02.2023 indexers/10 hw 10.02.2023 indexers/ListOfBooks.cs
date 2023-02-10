using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class ListOfBooks
    {
        private Book[] books;

        public ListOfBooks()
        {
            books = new Book[1];
            books[0] = new Book();
        }
        public ListOfBooks(int number_of_books)
        {
            books = new Book[number_of_books];
            for (int i = 0; i < number_of_books; i++)
            {
                books[i] = new Book();
            }
        }
        public ListOfBooks(params Book[] books)
        {
            if (books.Length == 0) throw new Exception("Нет аргументов");

            this.books = books;

        }

        public int GetQuantity()
        {
            return books.Length;
        }
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length) return books[index];
                else throw new Exception("Некоректный индекс");
            }
            set
            {
                if (index >= 0 && index < books.Length) books[index] = value;
                else throw new Exception("Некоректный индекс");
            }
        }
        public static ListOfBooks operator +(ListOfBooks list, Book book)
        {
            ListOfBooks result = new ListOfBooks(list.GetQuantity() + 1);
            //Console.WriteLine(result.GetQuantity());

            for (int i = 0; i < list.books.Length; i++)
            {
                result.books[i] = list.books[i];
            }

            result.books[result.GetQuantity() - 1] = book;
            return result;
        }

        public static ListOfBooks operator -(ListOfBooks list, int num)
        {
            ListOfBooks result = new ListOfBooks(list.GetQuantity() - num);
            //Console.WriteLine(result.GetQuantity());

            for (int i = 0; i < result.books.Length; i++)
            {
                result.books[i] = list.books[i];
            }

            return result;
        }

        public bool IsThereOn(Book book)
        {
            for (int i = 0; i < this.GetQuantity(); i++)
            {
                if (this.books[i] == book) return true;
            }
            return false;
        }

        public override string ToString()
        {
            string buf = string.Empty;

            for (int i = 0; i < books.Length; i++)
            {
                buf += books[i].ToString() + "\n\n";
            }

            return buf;
        }
    }
}