using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_3._0
{
    //класс для управления словарями
    public class DictionaryManager
    {
        private List<Dictionary> dictionaries;  // список всех словарей

        public DictionaryManager()
        {
            dictionaries = new List<Dictionary>();
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
        public void RemoveWordFromDictionary(string language, string term)
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
            throw new Exception($"Словарь на языке '{language}' не найден!");
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
            throw new Exception($"Словарь на языке '{language}' не найден!");
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
