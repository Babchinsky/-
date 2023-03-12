using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем новое слово
            CWord hello = new CWord("hello");

            // Создаем новый словарь
            Dictionary myDictionary = new Dictionary();
            myDictionary.Words = hello;
            myDictionary.Name = "English-Russian Dictionary";
            myDictionary.Type = DictionaryType.English_Russian;

            

            // Создаем новый перевод для слова hello
            Translation helloTranslation = new Translation("привет", "Russian");

            // Добавляем слово и его перевод в словарь
            myDictionary.AddWord(hello);
            //myDictionary.AddTranslation(hello, helloTranslation);

            //// Ищем перевод для слова hello
            //List<Translation> helloTranslations = myDictionary.FindTranslations(hello);
            //foreach (Translation translation in helloTranslations)
            //{
            //    Console.WriteLine($"{hello.Word} - {translation.Word}");
            //}

            //// Удаляем перевод для слова hello
            //myDictionary.RemoveTranslation(hello, helloTranslation);

        }
    }
}
