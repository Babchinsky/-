using System;
using System.Collections;
public class SamplesHashtable
{

    public static void Main()
    {

        // Создание и инициализация Хэш-таблицы
        Hashtable myHT = new Hashtable();
        myHT.Add("one", "The");
        myHT.Add("two", "quick");
        myHT.Add("three", "brown");
        myHT["four"] = "fox";

        // Отображение Хэш-таблицы
        Console.WriteLine("The Hashtable contains the following:");
        PrintKeysAndValues(myHT);
    }


    public static void PrintKeysAndValues(Hashtable myHT)
    {
        // DictionaryEntry - элемент словаря (ключ - значение)
        Console.WriteLine("\t-KEY-\t-VALUE-");
        foreach (DictionaryEntry de in myHT)
            Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
        Console.WriteLine();
    }
}
