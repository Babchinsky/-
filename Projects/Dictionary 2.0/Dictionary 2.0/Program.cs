using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Console Dictionary!");

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Create a dictionary");
                Console.WriteLine("2. Add a word to a dictionary");
                Console.WriteLine("3. Replace a word or translation in a dictionary");
                Console.WriteLine("4. Delete a word or translation from a dictionary");
                Console.WriteLine("5. Search for a translation");
                Console.WriteLine("6. Export a word and its translations");
                Console.WriteLine("7. Quit");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateDictionary();
                        break;
                    case "2":
                        AddWord();
                        break;
                    case "3":
                        ReplaceWord();
                        break;
                    case "4":
                        DeleteWord();
                        break;
                    case "5":
                        SearchTranslation();
                        break;
                    case "6":
                        ExportWord();
                        break;
                    case "7":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void CreateDictionary()
        {
            Console.WriteLine("What language is the dictionary?");
            var language = Console.ReadLine();

            Console.WriteLine("What type of dictionary is it (e.g. English-Spanish)?");
            var type = Console.ReadLine();

            var dictionary = new Dictionary(language, type);
            SaveDictionary(dictionary);

            Console.WriteLine($"Dictionary {type} ({language}) created successfully!");
        }

        private static void AddWord()
        {
            Console.WriteLine("What is the word you want to add?");
            var word = Console.ReadLine();

            Console.WriteLine("What is the translation of the word?");
            var translation = Console.ReadLine();

            Console.WriteLine("What language is the word in?");
            var language = Console.ReadLine();

            Console.WriteLine("What type of dictionary is it (e.g. English-Spanish)?");
            var type = Console.ReadLine();

            var dictionary = LoadDictionary(language, type);
            if (dictionary == null)
            {
                Console.WriteLine($"Dictionary {type} ({language}) does not exist.");
                return;
            }

            var existingWord = dictionary.FindWord(word);
            if (existingWord != null)
            {
                existingWord.AddTranslation(translation);
                SaveDictionary(dictionary);
                Console.WriteLine($"Translation added for {word} in {language}.");
            }
            else
            {
                var newWord = new Word(word);
                newWord.AddTranslation(translation);
                dictionary.AddWord(newWord);
                SaveDictionary(dictionary);
                Console.WriteLine($"Word {word} added to dictionary {type} ({language}) with translation {translation}.");
            }
        }

        private static void ReplaceWord()
        {
            Console.WriteLine("Введите слово, которое нужно заменить:");
            string word = Console.ReadLine();

            Console.WriteLine("Введите перевод слова, который нужно заменить:");
            string translation = Console.ReadLine();

            Console.WriteLine("Введите новый перевод слова:");
            string newTranslation = Console.ReadLine();

            Dictionary dictionary = LoadDictionary();

            Word existingWord = dictionary.FindWord(word);

            if (existingWord != null)
            {
                Translation existingTranslation = existingWord.FindTranslation(translation);

                if (existingTranslation != null)
                {
                    existingTranslation.Text = newTranslation;
                    Console.WriteLine("Перевод слова заменен");
                }
                else
                {
                    Console.WriteLine("Перевод слова не найден");
                }
            }
            else
            {
                Console.WriteLine("Слово не найдено");
            }

            SaveDictionary(dictionary);
        }

        private static void DeleteWord()
        {
            Console.WriteLine("Введите слово, которое нужно удалить:");
            string word = Console.ReadLine();

            Dictionary dictionary = LoadDictionary();

            Word existingWord = dictionary.FindWord(word);

            if (existingWord != null)
            {
                dictionary.RemoveWord(existingWord);
                Console.WriteLine("Слово удалено из словаря");
            }
            else
            {
                Console.WriteLine("Слово не найдено");
            }

            SaveDictionary(dictionary);
        }

        private static void SearchTranslation()
        {
            Console.WriteLine("Введите слово, перевод которого нужно найти:");
            string word = Console.ReadLine();

            Dictionary dictionary = LoadDictionary();

            Word existingWord = dictionary.FindWord(word);

            if (existingWord != null)
            {
                Console.WriteLine("Переводы слова \"{0}\":", word);

                foreach (Translation translation in existingWord.Translations)
                {
                    Console.WriteLine(translation.Text);
                }
            }
            else
            {
                Console.WriteLine("Слово не найдено");
            }
        }

        private static void ExportWord()
        {
            Console.Write("Enter the dictionary name: ");
            string dictionaryName = Console.ReadLine();
            Dictionary dictionary = LoadDictionary(dictionaryName);

            Console.Write("Enter the word to export: ");
            string word = Console.ReadLine();
            List<string> translations = dictionary.GetTranslations(word);

            if (translations == null)
            {
                Console.WriteLine("Word not found in dictionary.");
                return;
            }

            Console.Write("Enter the filename to export to: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(word);

                foreach (string translation in translations)
                {
                    writer.WriteLine(translation);
                }
            }

            Console.WriteLine("Word exported successfully.");
        }

    }
}