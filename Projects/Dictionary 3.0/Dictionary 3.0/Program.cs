using System;
using System.Collections.Generic;


namespace Dictionary_3._0
{
    internal class Program
    {
        //START//////////////////////////////////////////////////////////// 1 Меню
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
                Console.WriteLine(" D. Экспорт в JSON                 ");
                Console.WriteLine(" E. Импорт из JSON                 ");
                Console.WriteLine(" F. Выйти                 ");
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
                        ShowDictionariesMenu(manager);
                        break;
                    case 'b':
                        Console.Clear();
                        CreateNewDictionaryMenu(manager);
                        break;
                    case 'c':
                        Console.Clear();
                        ChooseDictionaryMenu(manager);
                        break;
                    case 'd':
                        Console.Clear();
                        manager.ExportToJson();
                        Console.WriteLine("Экспорт завершён. Нажмите любую кнопку, чтобы вернуться");
                        Console.ReadKey();
                        break;
                    case 'e':
                        Console.Clear();
                        manager.ImportFromJson();
                        Console.WriteLine("Импорт завершён. Нажмите любую кнопку, чтобы вернуться");
                        Console.ReadKey();
                        break;
                    case 'f':
                        return;
                }
            } while (true);
        }
        //END////////////////////////////////////////////////////////////// 1 Меню

        static void ShowDictionariesMenu(DictionaryManager manager)
        {
            if (manager.IsEmpty() == true) Console.WriteLine("Список словарей пуст");
            else manager.ShowAll();

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

        static void CreateNewDictionaryMenu(DictionaryManager manager)
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

        //START//////////////////////////////////////////////////////////// 2 Меню
        static void ChooseDictionaryMenu(DictionaryManager manager)
        {
            if (manager.IsEmpty() == true)
            {
                Console.WriteLine("Список словарей пуст");

                Console.WriteLine("Нажмите любую клавишу, чтобы вернуться");
                Console.ReadKey();
                return;
            }

            string[] languages = new string[manager.dictionaries.Count];

            for (int i = 0; i < manager.dictionaries.Count; i++)
            {
                languages[i] = manager.dictionaries[i].Language;
            }


            int id_dict;
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите словарь: ");
                manager.ShowLanguages();



                id_dict = Convert.ToInt32(Console.ReadLine());
                if (id_dict < 1 || id_dict > manager.dictionaries.Count)
                {
                    Console.WriteLine("Неверно введённое число. Попробуйте снова, но перед этим нажмите любую клавишу.");
                    Console.ReadKey();
                }
                else break;
            } while (true);



            char answer;
            do
            {
                Console.Clear();
                Console.WriteLine("IIIIIIIIIIIIIIIIIIIIIIIIIIII");
                Console.WriteLine(" A. Показать словарь ");
                Console.WriteLine(" B. Показать перевод слова");
                Console.WriteLine(" C. Добавить слово");
                Console.WriteLine(" D. Удалить слово"); 
                Console.WriteLine(" E. Удалить словарь");
                Console.WriteLine(" F. Удалить перевод у слова");
                Console.WriteLine(" G. Добавить перевод слову");
                Console.WriteLine(" H. Назад");
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
                        ShowSelectedDictionaryMenu(manager, languages[id_dict - 1]);
                        break;
                    case 'b':
                        Console.Clear();
                        ShowTranslationMenu(manager, languages[id_dict - 1]);
                        break;
                    case 'c':
                        Console.Clear();
                        AddWordInSelectedDictionaryMenu(manager, languages[id_dict - 1]);
                        break;
                    case 'd':
                        Console.Clear();
                        RemoveWordFromSelectedDictionaryMenu(manager, languages[id_dict - 1]);
                        break;
                    case 'e':
                        Console.Clear();
                        manager.RemoveSelectedDictionary(languages[id_dict - 1]);
                        Console.WriteLine("Словарь удалён. Нажмите любую кнопку, чтобы вернуться");
                        Console.ReadKey();
                        break;
                    case 'f':
                        Console.Clear();
                        RemoveTranslationFromSelectedDictionaryMenu(manager, languages[id_dict - 1]);
                        break;
                    case 'g':
                        Console.Clear();
                        AddTranslationToWordInSelectedDictionary(manager, languages[id_dict - 1]);
                        break;
                    case 'h':
                        return;
                }
            } while (true);
        }
        //END////////////////////////////////////////////////////////////// 2 Меню

        static void ShowSelectedDictionaryMenu(DictionaryManager manager, string language)
        {
            if (manager.IsEmpty() == true) Console.WriteLine("Список словарей пуст");
            else manager.ShowSelectedDictionary(language);

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

        static void ShowTranslationMenu(DictionaryManager manager, string language)
        {
            Console.WriteLine("Введите слово, к которому хотите найти перевод в этом словаре");
            string find = Console.ReadLine();

            
            manager.FindWordInDictionary(language, find);
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться назад");
            Console.ReadKey();
            return;
        }

        static void AddWordInSelectedDictionaryMenu(DictionaryManager manager, string language)
        {
            Console.WriteLine("Напишите слово, которое хотите добавить: ");
            string term = Console.ReadLine();


            Console.WriteLine("Напишите перевод (если переводов несколько, то напишите\n" +
                "слова через запятую): ");
            string translation = Console.ReadLine();
            string[] translationWords = translation.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);


            List<string> translationList = new List<string>();
            foreach (string word in translationWords)
            {
                translationList.Add(word);
            }

            manager.AddWordToDictionary(language, term, translationList);


        }

        static void RemoveWordFromSelectedDictionaryMenu(DictionaryManager manager, string language)
        {
            Console.WriteLine("Напишите слово, которое хотите удалить");
            string delete = Console.ReadLine();

            if (manager.IsWordInSelectedDictionary(language, delete) == false) 
            {
                Console.WriteLine("Слово не найдено. Нажмите любую клавишу, чтобы вернуться");
                Console.ReadKey();
                return;
            }
            
            manager.RemoveWordFromSelectedDictionary(language, delete);
            Console.WriteLine($"Слово \"{delete}\" удалено");

            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться");
            Console.ReadKey();
            return;
        }

        static void RemoveTranslationFromSelectedDictionaryMenu(DictionaryManager manager, string language)
        {
            Console.WriteLine("Напишите слово, у которого хотите удалить перевод: ");
            string deleteWord = Console.ReadLine();

            if (manager.IsWordInSelectedDictionary(language, deleteWord) == false)
            {
                Console.WriteLine("Слово не найдено. Нажмите любую клавишу, чтобы вернуться");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Напишите перевод, который хотите удалить: ");
            string deleteTranslate = Console.ReadLine();

            manager.RemoveTranslationFromDictionary(language, deleteWord, deleteTranslate);

            
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться");
            Console.ReadKey();
            return;
        }

        static void AddTranslationToWordInSelectedDictionary(DictionaryManager manager, string language)
        {
            Console.WriteLine("Напишите слово, которому хотите добавить перевод: ");
            string addWord = Console.ReadLine();

            if (manager.IsWordInSelectedDictionary(language, addWord) == false)
            {
                Console.WriteLine("Слово не найдено. Нажмите любую клавишу, чтобы вернуться");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Напишите перевод, который хотите добавить: ");
            string addTranslate = Console.ReadLine();

            manager.AddTranslationToDictionary(language, addWord, addTranslate);


            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться");
            Console.ReadKey();
            return;
        }
    }
}