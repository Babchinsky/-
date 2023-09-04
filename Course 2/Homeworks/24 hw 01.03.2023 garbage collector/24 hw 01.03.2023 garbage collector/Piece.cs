using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Piece: IDisposable
    {
        private string name;
        private string author;
        private string genre;
        private int year;
        private bool disposed;

        public Piece(string name, string author, string genre, int year)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.year = year;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Освободить все управляемые ресурсы здесь
                }

                // Освободить все неуправляемые ресурсы здесь
                disposed = true;
            }
        }

        ~Piece()
        {
            Console.WriteLine("Destructor called");
            Dispose(false);
        }


        public override string ToString()
        {
            return $"Piece: {name}\nAuthor: {author}\nGenre: {genre}\nYear: {year}\n";
        }
    }
}
