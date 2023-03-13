using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_3._0
{
    // класс для хранения словаря на определенном языке
    public class Dictionary
    {
        public string Language { get; set; }  // язык словаря
        public List<Word> Words { get; set; }  // список слов с их переводами

        public Dictionary(string language)
        {
            Language = language;
            Words = new List<Word>();
        }

        // добавление слова и его переводов в словарь
        public void AddWord(string term, List<string> translations)
        {
            Words.Add(new Word(term, translations));
        }

        // удаление слова из словаря
        public void RemoveWord(string term)
        {
            foreach (Word word in Words)
            {
                if (term == word.Term)
                {
                    Words.Remove(word);
                    return;
                }
            }
            throw new Exception("Слово не найдено");
        }

        // удаление перевода у слова в словаре (нельзя удалить единственный вариант перевода)
        public void RemoveTranslation(string term, string tran)
        {
            foreach (Word word in Words)
            {
                if (word.Term == term)
                {
                    word.RemoveTranslation(tran);
                    return;
                }
                else throw new Exception("Слово в словаре не найдено");
            }
        }

        public void FindWord(string term)
        {
            foreach (Word word in Words)
            {
                if (word.Term == term)
                {
                    Console.WriteLine(word);
                    return;
                }
                else throw new Exception("Слово не найдено");
            }
        }

        public void ChangeWord(string term_old, string term_new, List<string> translations)
        {
            foreach (Word word in Words)
            {
                if (word.Term == term_old)
                {
                    word.ChangeWord(term_new, translations);
                    return;
                }
                else throw new Exception("Слово не найдено");
            }
        }

        public override string ToString()
        {
            return "\t\t\t" + Language + "\n" + string.Join("\n", Words);
        }
    }

    // класс для управления словарями
    //public class DictionaryManager
    //{
    //    private List<Dictionary> dictionaries;  // список всех словарей

    //    public DictionaryManager()
    //    {
    //        dictionaries = new List<Dictionary>();
    //    }

    //    // создание нового словаря
    //    public void CreateDictionary(string language)
    //    {
    //        dictionaries.Add(new Dictionary(language));
    //    }

    //    // добавление слова и его переводов в указанный словарь
    //    public void AddWordToDictionary(string language, string term, List<string> translations)
    //    {
    //        foreach (var dict in dictionaries)
    //        {
    //            if (dict.Language == language)
    //            {
    //                dict.AddWord(term, translations);
    //                return;
    //            }
    //        }
    //        Console.WriteLine($"Словарь на языке '{language}' не найден!");
    //    }

    //    // поиск перевода слова в указанном словаре
    //    public void TranslateWord(string language, string term)
    //    {
    //        foreach (var dict in dictionaries)
    //        {
    //            if (dict.Language == language)
    //            {
    //                foreach (var word in dict.Words)
    //                {
    //                    if (word.Term == term)
    //                    {
    //                        Console.WriteLine($"Перевод слова '{term}' на язык '{language}':");
    //                        foreach (var translation in word.Translations)
    //                        {
    //                            Console.WriteLine($"- {translation}");
    //                        }
    //                        return;
    //                    }
    //                }
    //                Console.WriteLine($"Перевод слова '{term}' на язык '{language}' не найден!");
    //                return;
    //            }
    //        }
    //        Console.WriteLine($"Словарь на языке '{language}' не найден!");
    //    }

    //    // замена слова или его перевода в словаре






    //    // удаление слова
    //    //public bool RemoveWord(string language, string word)
    //    //{
    //    //    foreach (var dictionary in dictionaries)
    //    //    {
    //    //        if (dictionary.Language == language && dictionary.Words.Contains(word))
    //    //        {
    //    //            //return dictionary.Words.Remove(word);
    //    //        }
    //    //    }

    //    //    return false;
    //    //}




    //    //public bool RemoveWordOrTranslation(string word, string translation, string language)
    //    //{
    //    //    Dictionary<string, string> dictionary = GetDictionary(language);
    //    //    if (dictionary == null)
    //    //    {
    //    //        return false; // Словарь не найден
    //    //    }

    //    //    if (translation != null)
    //    //    {
    //    //        // Удаление перевода
    //    //        if (dictionary.ContainsKey(word))
    //    //        {
    //    //            List<string> translations = dictionary[word].Split(',').ToList();
    //    //            if (translations.Contains(translation))
    //    //            {
    //    //                if (translations.Count == 1)
    //    //                {
    //    //                    return false; // Последний вариант перевода нельзя удалить
    //    //                }
    //    //                else
    //    //                {
    //    //                    translations.Remove(translation);
    //    //                    dictionary[word] = string.Join(",", translations);
    //    //                    return true;
    //    //                }
    //    //            }
    //    //            else
    //    //            {
    //    //                return false; // Перевод не найден
    //    //            }
    //    //        }
    //    //        else
    //    //        {
    //    //            return false; // Слово не найдено
    //    //        }
    //    //    }
    //    //    else
    //    //    {
    //    //        // Удаление слова и всех его переводов
    //    //        return dictionary.Remove(word);
    //    //    }
    //    //}
    //}
}
