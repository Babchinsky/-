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
            }
            Console.WriteLine("Слово не найдено");
            //throw new Exception("Слово не найдено");
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

    
}
