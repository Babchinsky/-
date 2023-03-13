using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using System.IO;

namespace Dictionary_3._0
{
    //класс для управления словарями
    public class DictionaryManager
    {
        public List<Dictionary> dictionaries;  // список всех словарей

        public DictionaryManager()
        {
            dictionaries = new List<Dictionary>();
        }

        public bool IsEmpty()
        {
            if (dictionaries.Count == 0) return true;
            return false;
        }

        public bool IsWordInSelectedDictionary(string language, string find)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    if (dict.IsWordIn(find)) return true;
                }
            }
            return false;
        }

        public void ShowLanguages()
        {
            for (int i = 0; i < dictionaries.Count; i++)
            {
                Console.WriteLine(i+1 + "." + dictionaries[i].Language);
            }
        }

        // 1. Создание нового словаря
        public void CreateDictionary(string language)
        {
            dictionaries.Add(new Dictionary(language));
        }

        // 2. Добавление слова и его переводов в указанный словарь
        public void AddWordToDictionary(string language, string term, List<string> translations)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dict.AddWord(term, translations);
                    return;
                }
            }
            //Console.WriteLine($"Словарь на языке '{language}' не найден!");
            throw new Exception ($"Словарь на языке '{language}' не найден!");
        }

        // 3. Замена слова или его перевода в словаре
        public void ChangeWordInDictionary(string language, string term_old, string term_new, List<string> translations)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                { 
                    dict.ChangeWord(term_old, term_new, translations);
                    return;
                }
            }
            throw new Exception($"Словарь на языке '{language}' не найден!");
        }

        // 4a. Удаление слова из словаря
        public void RemoveWordFromSelectedDictionary(string language, string term)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dict.RemoveWord(term);
                    return;
                }
            }
            throw new Exception($"Словарь на языке '{language}' не найден!");
        }

        // 4б. Удаление перевода у слова в словаре (нельзя удалить единственный вариант перевода)
        public void RemoveTranslationFromDictionary(string language, string term, string tran)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dict.RemoveTranslation(term, tran);
                    return;
                }
            }
            Console.WriteLine($"Словарь на языке {language} не найден!");
            //throw new Exception($"Словарь на языке '{language}' не найден!");
        }

        public void AddTranslationToDictionary(string language, string term, string tran)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dict.AddTranslation(term, tran);
                    return;
                }
            }
            Console.WriteLine($"Словарь на языке {language} не найден!");
            //throw new Exception($"Словарь на языке '{language}' не найден!");
        }

        // 5. Поиск перевода слова в указанном словаре
        public void FindWordInDictionary(string language, string term)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dict.FindWord(term);
                    return;
                }
            }
            Console.WriteLine($"Слово {term} в словаре '{language}' не найдено!");
            //throw new Exception($"Словарь на языке '{language}' не найден!");
        }

        // Показать выбранный словарь
        public void ShowSelectedDictionary(string language)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dict.ShowDictionary();
                    return;
                }
            }
            Console.WriteLine("Словарь не найден");
        }

        // Удалить выбранный словарь
        public void RemoveSelectedDictionary(string language)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    dictionaries.Remove(dict);
                    return;
                }
            }
            Console.WriteLine("Словарь не найден");
        }

        // Метод для импорта данных из JSON-файла
        public void ImportFromJson()
        {
            Console.WriteLine("Напишите путь к файлу: ");
            //string filePath = Console.ReadLine();
            string filePath = "../../";
            filePath += "Dictionaries.json";

            using (StreamReader reader = new StreamReader(filePath))
            {
                string json = reader.ReadToEnd();
                dictionaries = JsonConvert.DeserializeObject<List<Dictionary>>(json);
            }
        }

        // Метод для экспорта данных в JSON-файл
        public void ExportToJson()
        {
            Console.WriteLine("Напишите путь к файлу: ");
            //string filePath = Console.ReadLine();
            string filePath = "../../";
            filePath += "Dictionaries.json";

            string json = JsonConvert.SerializeObject(dictionaries);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(json);
            }
        }

        public void ShowAll()
        {
            foreach (Dictionary dictionary in dictionaries)
            {
                Console.WriteLine(dictionary);
            }
        }

        public override string ToString()
        {
            string buf = string.Empty;

            foreach(var dict in dictionaries)
            {
                buf += dict + "\n";
            }

            return buf;
        }
    }
}
