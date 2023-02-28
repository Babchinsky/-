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
        myHT.Add("four", "fox");
        myHT.Add("five", "jumped");

        // Отображаем элементы Хэш-таблицы и их количество
        Console.WriteLine("Initially,");
        Console.WriteLine("   Count    : {0}", myHT.Count);
        Console.WriteLine("   Values:");
        PrintKeysAndValues(myHT);

        // Очищаем Хэш-таблицу
        myHT.Clear();

        // Отображаем элементы Хэш-таблицы и их количество
        Console.WriteLine("After Clear,");
        Console.WriteLine("   Count    : {0}", myHT.Count);
        Console.WriteLine("   Values:");
        PrintKeysAndValues(myHT);
    }


    public static void PrintKeysAndValues(Hashtable myHT)
    {
        Console.WriteLine("\t-KEY-\t-VALUE-");
        foreach (DictionaryEntry de in myHT)
            Console.WriteLine("\t{0}:\t{1}", de.Key, de.Value);
        Console.WriteLine();
    }

}

