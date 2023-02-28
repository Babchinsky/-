using System;
using System.Collections;
public class SamplesHashtable
{

    public static void Main()
    {

        // Создаём и инициализируем Хэш-таблицу
        Hashtable myHT = new Hashtable();
        myHT.Add(0, "zero");
        myHT.Add(1, "one");
        myHT.Add(2, "two");
        myHT.Add(3, "three");
        myHT.Add(4, "four");

        // Отображаем содержимое Хэш-таблицы
        Console.WriteLine("The Hashtable contains the following values:");
        PrintIndexAndKeysAndValues(myHT);

        // Ищем в Хэш-таблице указанный ключ
        int myKey = 2;
        Console.WriteLine("The key \"{0}\" is {1}.", myKey, myHT.ContainsKey(myKey) ? "in the Hashtable" : "NOT in the Hashtable");
        myKey = 6;
        Console.WriteLine("The key \"{0}\" is {1}.", myKey, myHT.ContainsKey(myKey) ? "in the Hashtable" : "NOT in the Hashtable");

        // Ищем в Хэш-таблице указанное значение
        String myValue = "three";
        Console.WriteLine("The value \"{0}\" is {1}.", myValue, myHT.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
        myValue = "nine";
        Console.WriteLine("The value \"{0}\" is {1}.", myValue, myHT.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
    }


    public static void PrintIndexAndKeysAndValues(Hashtable myHT)
    {
        int i = 0;
        Console.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-");
        foreach (DictionaryEntry de in myHT)
            Console.WriteLine("\t[{0}]:\t{1}\t{2}", i++, de.Key, de.Value);
        Console.WriteLine();
    }

}


