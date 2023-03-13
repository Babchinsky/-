using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    // класс для хранения слова и его переводов
    public class Word
    {
        public string Term { get; set; }  // слово на оригинальном языке
        public List<string> Translations { get; set; }  // список переводов на другие языки

        public Word(string term, List<string> translations)
        {
            Term = term;
            Translations = translations;
        }
    }

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
    }

    // класс для управления словарями
    public class DictionaryManager
    {
        private List<Dictionary> dictionaries;  // список всех словарей

        public DictionaryManager()
        {
            dictionaries = new List<Dictionary>();
        }

        // создание нового словаря
        public void CreateDictionary(string language)
        {
            dictionaries.Add(new Dictionary(language));
        }

        // добавление слова и его переводов в указанный словарь
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
            Console.WriteLine($"Словарь на языке '{language}' не найден!");
        }

        // поиск перевода слова в указанном словаре
        public void TranslateWord(string language, string term)
        {
            foreach (var dict in dictionaries)
            {
                if (dict.Language == language)
                {
                    foreach (var word in dict.Words)
                    {
                        if (word.Term == term)
                        {
                            Console.WriteLine($"Перевод слова '{term}' на язык '{language}':");
                            foreach (var translation in word.Translations)
                            {
                                Console.WriteLine($"- {translation}");
                            }
                            return;
                        }
                    }
                    Console.WriteLine($"Перевод слова '{term}' на язык '{language}' не найден!");
                    return;
                }
            }
            Console.WriteLine($"Словарь на языке '{language}' не найден!");
        }
    }

    // тестирование функций словаря
    static void Program(string[] args)
    {
        DictionaryManager manager = new DictionaryManager();

        // создание словаря английский-русский
        manager.CreateDictionary("английский-русский");

        // добавление слов в словарь
        manager.AddWordToDictionary("английский-русский", "hello", new List<string> { "привет", "здравствуйте" });
        manager.AddWordToDictionary("английский-русский", "world", new List<string> { "мир", "вселенная" });
        manager.AddWordToDictionary("английский-русский", "cat", new List<string> { "кот", "кошка" });

        // поиск перевода слова в словаре
        manager.TranslateWord("английский-русский", "hello");
        manager.TranslateWord("английский-русский", "world");
        manager.TranslateWord("английский-русский", "dog");
    }
}