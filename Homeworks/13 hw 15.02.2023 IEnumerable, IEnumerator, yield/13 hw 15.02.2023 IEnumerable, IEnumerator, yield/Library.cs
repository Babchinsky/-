using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_hw_15._02._2023_IEnumerable__IEnumerator__yield
{
    internal class Library: IEnumerable, IEnumerator
    {
        Book[] books;
        int curpos = -1;

        public Library(int length) 
        {
            books= new Book[length];
            for (int i = 0; i < length; i++)
            {
                books[i] = new Book();
            }
        }

        public Library() :this(1){ }
        public Library(Book[] books)
        {
            this.books = books;
        }

        public void InputBook()
        {
            for (int i = 0; i < books.Length; i++)
                books[i].Init();
        }
        public void ShowBooks()
        {
            for (int i = 0; i < books.Length; i++)
                books[i].Show();
        }


        public IEnumerator GetEnumerator()
        {
            //Console.WriteLine("\nВыполняется метод GetEnumerator");
            // возвращается ссылка на объект класса, реализующего перечислитель
            return this;
        }

        #region enumerator
        //Устанавливает перечислитель в его начальное положение, т. е. перед первым элементом коллекции
        public void Reset()
        {
            //Console.WriteLine("\nВыполняется метод Reset");
            curpos = -1;
        }
        public object Current // Получает текущий элемент в коллекции
        {
            get
            {
                //Console.WriteLine("\nВыполняется свойство Current");
                return books[curpos];
            }
        }
        // Перемещает перечислитель к следующему элементу коллекции
        public bool MoveNext()
        {
            //Console.WriteLine("\nВыполняется метод MoveNext");
            if (curpos < books.Length - 1)
            {
                curpos++;
                return true;
            }
            else
            {
                this.Reset();
                return false;
            }

        }
        #endregion enumerator
    }
}
