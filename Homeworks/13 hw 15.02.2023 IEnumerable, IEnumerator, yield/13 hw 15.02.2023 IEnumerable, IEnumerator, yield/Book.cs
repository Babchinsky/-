using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _13_hw_15._02._2023_IEnumerable__IEnumerator__yield
{
    internal class Book: IComparable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

        public Book()
        {
            Title = string.Empty;
            Author = string.Empty;
            Year = 0;
            Genre = string.Empty;
            Description = string.Empty;
        }

        public Book(string title, string author, int year, string genre, string description)
        {
            this.Title = title;
            this.Author = author;
            this.Year = year;
            this.Genre = genre;
            this.Description = description;
        }

        public Book(Book obj) : this(obj.Title, obj.Author, obj.Year, obj.Genre, obj.Description)
        { }

        private void InitTitle()
        {
            Console.WriteLine("Enter the title: ");

            try
            {
                Title = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitTitle();
            }


        }
        private void InitAuthor()
        {
            Console.WriteLine("Enter the author: ");
            try
            {
                Author = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitAuthor();
            }
        }
        private void InitYear()
        {
            Console.WriteLine("Enter the year: ");
            try
            {
                Year = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitYear();
            }
        }
        private void InitGenre()
        {
            Console.WriteLine("Enter the genre: ");
            try
            {
                Genre = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitGenre();
            }
        }
        private void InitDescription()
        {
            Console.WriteLine("Enter the description: ");
            try
            {
                Description = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitAuthor();
            }
        }

        public void Init()
        {
            InitTitle();
            InitAuthor();
            InitYear();
            InitGenre();
            InitDescription();
        }
        
        public void Show()
        {
            Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nYear: {Year}\nGenre: {Genre}\nDescription: {Description}\n");
        }
        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nYear: {Year}\nGenre: {Genre}\nDescription: {Description}";
        }

        public int CompareTo(object obj)
        {
            if (obj is Book)
                return Title.CompareTo((obj as Book).Title);

            throw new NotImplementedException();
        }


        public class SortByTitle : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).Title.CompareTo((obj2 as Book).Title);
                }

                throw new NotImplementedException();
            }
        }

        public class SortByAuthor : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).Author.CompareTo((obj2 as Book).Author);
                }

                throw new NotImplementedException();
            }
        }

        public class SortByYear : IComparer
        {
            int IComparer.Compare(object obj1, object obj2)
            {
                if (obj1 is Book && obj2 is Book)
                {
                    return (obj1 as Book).Year.CompareTo((obj2 as Book).Year);
                }

                throw new NotImplementedException();
            }
        }
    }
}
