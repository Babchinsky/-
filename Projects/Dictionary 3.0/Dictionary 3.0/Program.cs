using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DictionaryManager manager = new DictionaryManager();


            char answer;
            do
            {
                Console.Clear();
                Console.WriteLine("IIIIIIIIIIIIIIIIIIIIIIIIIIII");
                Console.WriteLine(" A. Показать все словари  ");
                Console.WriteLine(" B. Создать новый словарь ");
                Console.WriteLine(" C. Выбрать словарь       ");
                Console.WriteLine(" D. Выйти                 ");
                Console.WriteLine("IIIIIIIIIIIIIIIIIIIIIIIIIIII");


                answer = Char.ToLower(Convert.ToChar(Console.ReadLine()));
                switch (answer)
                {
                    default:
                        Console.WriteLine("Неверно нажатая клавиша. Попробуйте нажать ещё раз, но перед этим нажмите любую клавишу");
                        Console.ReadKey();
                        break;
                    case 'a':
                        Console.Clear();
                        ShowDictionaries(manager);
                        break;
                    case 'b':
                        Console.Clear();
                        CreateNewDictionary(manager);
                        break;
                    case 'c':
                        Console.Clear();
                        ChooseDictionary(manager);
                        break;
                    case 'd':
                        return;
                }
            } while (true);

            #region MyRegion
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
            #endregion


        }


        static void ShowDictionaries(DictionaryManager manager)
        {
            if (manager.IsEmpty() == true) Console.WriteLine("Список словарей пуст");
            else manager.ShowLanguages();


            Console.WriteLine("Нажмите Escape, чтобы вернуться ");

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        static void CreateNewDictionary(DictionaryManager manager)
        {
            Console.WriteLine("Введите название словаря: ");
            string language = Console.ReadLine();


            manager.CreateDictionary(language);


            Console.WriteLine("Нажмите Escape, чтобы вернуться ");
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }

        static void ChooseDictionary(DictionaryManager manager)
        {
            if (manager.IsEmpty() == true)
            {
                Console.WriteLine("Список словарей пуст");

                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться");
                Console.ReadKey();
                return;
            }


            char id;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите словарь: ");
                manager.ShowLanguages();


                id = Convert.ToChar(Console.ReadLine());
                if (id < 1 || id > manager.dictionaries.Count)
                {
                    Console.WriteLine("Неверно введённое число. Попробуйте снова, но перед этим нажмите любую клавишу.");
                    Console.ReadKey();
                }
                else break;
            } while (true);
        }
    }
}