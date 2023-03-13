using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DictionaryManager manager = new DictionaryManager();

            //// создание словаря английский-русский
            //manager.CreateDictionary("английский-русский");

            //// добавление слов в словарь
            //manager.AddWordToDictionary("английский-русский", "hello", new List<string> { "привет", "здравствуйте" });
            //manager.AddWordToDictionary("английский-русский", "world", new List<string> { "мир", "вселенная" });
            //manager.AddWordToDictionary("английский-русский", "cat", new List<string> { "кот", "кошка" });

            //// поиск перевода слова в словаре
            //manager.TranslateWord("английский-русский", "hello");
            //manager.TranslateWord("английский-русский", "world");
            //manager.TranslateWord("английский-русский", "dog");



            Dictionary dictionary = new Dictionary("англо-русский");
            dictionary.AddWord("hello", new List<string> { "привет", "здравствуйте" });
            dictionary.AddWord("world", new List<string> { "мир", "вселенная" });
            dictionary.AddWord("cat", new List<string> { "кот", "кошка" });
            Console.WriteLine(dictionary);


            dictionary.ChangeWord("hello", "hi", new List<string> { "приветствую" });
            Console.WriteLine(dictionary);

            //dictionary.RemoveWord("hello");
            //Console.WriteLine(dictionary);

            //dictionary.RemoveTranslation("world", "мир");
            //Console.WriteLine(dictionary);

            // срабатывает исключение
            ////dictionary.RemoveTranslation("world", "вселенная");
            ////Console.WriteLine(dictionary);


        }
    }
}