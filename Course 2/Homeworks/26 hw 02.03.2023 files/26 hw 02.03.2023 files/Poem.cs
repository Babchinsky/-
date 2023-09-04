using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_hw_02._03._2023_files
{
    public class Poem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Text { get; set; }
        public string Theme { get; set; }
    }

    public class PoemCollection : List<Poem>
    {
        public void AddPoem(Poem poem)
        {
            this.Add(poem);
        }
        public void RemovePoem(Poem poem)
        {
            this.Remove(poem);
        }
        public void RemoveLastPoem()
        {
            this.RemoveAt(this.Count - 1);
        }
        public void UpdatePoem(Poem poem)
        {
            int index = this.FindIndex(p => p.Title == poem.Title);
            if (index != -1)
            {
                this[index] = poem;
            }
        }
        public List<Poem> FindByTitle(string title)
        {
            return this.FindAll(p => p.Title == title);
        }
        public List<Poem> FindByAuthor(string author)
        {
            return this.FindAll(p => p.Author == author);
        }
        public List<Poem> FindByYear(int year)
        {
            return this.FindAll(p => p.Year == year);
        }
        public List<Poem> FindByTheme(string theme)
        {
            return this.FindAll(p => p.Theme == theme);
        }
    }

    public class PoemManager
    {
        private PoemCollection poems;

        public PoemManager()
        {
            this.poems = new PoemCollection();
        }

        public void AddPoem(Poem poem)
        {
            this.poems.AddPoem(poem);
        }

        public void RemovePoem(Poem poem)
        {
            this.poems.RemovePoem(poem);
        }

        public void UpdatePoem(Poem poem)
        {
            this.poems.UpdatePoem(poem);
        }

        public List<Poem> FindByTitle(string title)
        {
            return this.poems.FindByTitle(title);
        }

        public List<Poem> FindByAuthor(string author)
        {
            return this.poems.FindByAuthor(author);
        }

        public List<Poem> FindByYear(int year)
        {
            return this.poems.FindByYear(year);
        }

        public List<Poem> FindByTheme(string theme)
        {
            return this.poems.FindByTheme(theme);
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (Poem poem in this.poems)
                {
                    writer.WriteLine($"{poem.Title},{poem.Author},{poem.Year},{poem.Theme},{poem.Text}");
                }
            }
        }

        public void ReadFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');

                    Poem poem = new Poem();
                    poem.Title = line[0];
                    poem.Author = line[1];
                    poem.Year = int.Parse(line[2]);
                    poem.Theme = line[3];
                    poem.Text = line[4];

                    this.poems.AddPoem(poem);
                }
            }
        }

        public int LengthOfPoem(Poem poem)
        {
            return poem.Text.Length;
        }
        public int YearOfPoem(Poem poem)
        {
            return poem.Year;
        }
    }
}
