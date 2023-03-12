using System.Collections.Generic;

public class Dictionary
{
    public string Name { get; set; }
    public DictionaryType Type { get; set; }
    public List<CWord> Words { get; set; }

    public Dictionary() { }

    public void AddWord(CWord word)
    {
        Words.Add(word);
    }

    public void RemoveWord(CWord word)
    {
        Words.Remove(word);
    }

    public void AddTranslation(CWord word, Translation translation)
    {
        word.Translations.Add(translation);
    }

    public void RemoveTranslation(CWord word, Translation translation)
    {
        word.Translations.Remove(translation);
    }

    public List<Translation> FindTranslations(CWord word)
    {
        return word.Translations;
    }
}

public enum DictionaryType
{
    English_Russian,
    Russian_English
}


public class CWord
{
    public string Word { get; set; }
    public List<Translation> Translations { get; set; }

    public CWord(string word)
    {
        Word = word;
        Translations = new List<Translation>();
    }
}

public class Translation
{
    public string Word { get; set; }
    public string Language { get; set; }

    public Translation(string word, string language)
    {
        Word = word;
        Language = language;
    }
}
