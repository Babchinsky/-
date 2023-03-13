using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_3._0
{
    // класс для хранения слова и его переводов
    public class Word
    {
        public string Term { get; set; }                // слово на оригинальном языке
        public List<string> Translations { get; set; }  // список переводов на другие языки

        public Word(string term, List<string> translations)
        {
            Term = term;
            Translations = translations;
        }

        // удаление перевода у слова (нельзя удалить единственный вариант перевода)
        public void RemoveTranslation(string tran)
        {
            if (Translations.Count == 1) throw new Exception("Нельзя удалить единственный вариант перевода");

            if (Translations.Contains(tran)) Translations.Remove(tran);
            else throw new Exception("Перевод не найден");
        }

        public void ChangeWord(string term, List<string> translations)
        {
            Term = term;
            Translations = translations;
        }

        public override string ToString()
        {
            return $"{Term} - {string.Join(", ", Translations)}";
        }
    }
}
