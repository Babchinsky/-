using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_hw_26._04._2023_MVC.Model
{
    class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }

        public Book() { }
        public Book(string n, string a)
        {
            Name = n;
            Author = a;
        }
        public override string ToString()
        {
            return $"Название: {Name}\tАвтор: {Author}\n";
        }


    }
}
