using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // заданный текст
        string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis eget leo ultrices, convallis risus in, bibendum felis. Sed quis urna convallis, luctus massa id, tempor justo. Sed mollis mauris vel mi vestibulum, in semper lorem faucibus. Sed a massa facilisis, feugiat velit a, consectetur nulla. Sed laoreet ante euismod neque ullamcorper ultrices. Suspendisse gravida dolor mauris, ut lacinia mi iaculis ut. Donec ut nulla massa. Phasellus vel mauris magna. Donec ac euismod quam. Sed nec molestie dolor. Fusce eu nisi ante. Maecenas in lectus at ipsum vehicula rhoncus.";

        // удаляем знаки препинания и приводим текст к нижнему регистру
        char[] separators = new char[] { ' ', ',', '.', ';', ':', '-', '!', '?', '\n', '\r', '\t' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        words = words.Select(w => w.ToLower()).ToArray();

        // создаем словарь для подсчета упоминаний слов
        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        // подсчитываем упоминания каждого слова
        foreach (string word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts[word] = 1;
            }
        }

        // выводим результаты
        foreach (KeyValuePair<string, int> pair in wordCounts)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
