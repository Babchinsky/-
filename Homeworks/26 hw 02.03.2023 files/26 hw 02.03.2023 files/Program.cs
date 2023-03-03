using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_hw_02._03._2023_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PoemManager manager = new PoemManager();

            // Добавляем стих в коллекцию
            Poem poem1 = new Poem { Title = "Осень", Author = "Сергей Есенин", Year = 1913, Text = "Осень, осень, я тебя люблю...", Theme = "Природа" };
            manager.AddPoem(poem1);

            // Ищем стихи по автору
            List<Poem> poemsByAuthor = manager.FindByAuthor("Сергей Есенин");

            // Сохраняем коллекцию в файл
            manager.SaveToFile("poems.txt");

            // Загружаем коллекцию из файла
            manager.ReadFromFile("poems.txt");
        }
    }
}
