using System;
using System.Collections;
public class SamplesHashtable
{

    public static void Main()
    {

        // Создаём и инициализируем Хэш-таблицу
        Hashtable myHT = new Hashtable();
        myHT.Add("1a", "The");
        myHT.Add("1b", "quick");
        myHT.Add("1c", "brown");
        myHT.Add("2a", "fox");
        myHT.Add("2b", "jumped");
        myHT.Add("2c", "over");
        myHT.Add("3a", "the");
        myHT.Add("3b", "lazy");
        myHT.Add("3c", "dog");

        // Отображаем Хэш-таблицу
        Console.WriteLine("The Hashtable initially contains the following:");
        PrintKeysAndValues(myHT);

        // Удаляем элемент с ключом "3b".
        myHT.Remove("3b");

        // Отображаем текущее состояние Хэш-таблицы
        Console.WriteLine("After removing \"lazy\":");
        PrintKeysAndValues(myHT);
    }


    public static void PrintKeysAndValues(Hashtable myHT)
    {
        foreach (DictionaryEntry de in myHT)
            Console.WriteLine("    {0}:    {1}", de.Key, de.Value);
        Console.WriteLine();
    }

}

