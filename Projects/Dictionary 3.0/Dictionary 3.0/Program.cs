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
            DictionaryManager manager = new DictionaryManager();

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1. Создать новый словарь");



            //// 1. Cоздание словаря английский-русский
            //manager.CreateDictionary("англо-русский");

            //// 2. Добавление слов в словарь
            //manager.AddWordToDictionary("англо-русский", "hello", new List<string> { "привет", "здравствуйте" });
            //manager.AddWordToDictionary("англо-русский", "world", new List<string> { "мир", "вселенная" });
            //manager.AddWordToDictionary("англо-русский", "cat", new List<string> { "кот", "кошка" });

            //Console.WriteLine(manager);

            //// 3. Замена слова или его перевода в словаре
            //manager.ChangeWordInDictionary("англо-русский", "hello", "hi", new List<string> { "приветствую" });
            //Console.WriteLine(manager);


            //// 4а. Удаление слова из словаря
            //manager.RemoveWordFromDictionary("англо-русский", "hi");
            //Console.WriteLine(manager);

            //// 4б. Удаление перевода у слова в словаре (нельзя удалить единственный вариант перевода)
            //manager.RemoveTranslationFromDictionary("англо-русский", "world", "вселенная");
            //Console.WriteLine(manager);


            //// 5. Поиск перевода слова в словаре
            //manager.FindWordInDictionary("англо-русский", "hello");
            //manager.FindWordInDictionary("англо-русский", "world");

        }
    }
}