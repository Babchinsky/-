using System;
using System.Collections;
public class SamplesHashtable
{

    public static void Main()
    {

        // Создаём и инициализируем Хэш-таблицу
        Hashtable mySourceHT = new Hashtable();
        mySourceHT.Add("A", "valueA");
        mySourceHT.Add("B", "valueB");

        // Создаём и инициализируем массив строк
        String[] myTargetArray = new String[15];
        myTargetArray[0] = "The";
        myTargetArray[1] = "quick";
        myTargetArray[2] = "brown";
        myTargetArray[3] = "fox";
        myTargetArray[4] = "jumped";
        myTargetArray[5] = "over";
        myTargetArray[6] = "the";
        myTargetArray[7] = "lazy";
        myTargetArray[8] = "dog";

        // Выводим на экран значения массива
        Console.WriteLine("The target Array contains the following before:");
        PrintValues(myTargetArray, ' ');

        // Копируем ключи из Хэш-таблицы в массив, начиная с индекса 6
        Console.WriteLine("After copying the keys, starting at index 6:");
        mySourceHT.Keys.CopyTo(myTargetArray, 6);

        // Выводим на экран значения массива
        PrintValues(myTargetArray, ' ');

        // Копируем значения из Хэш-таблицы в массив, начиная с индекса 6
        Console.WriteLine("After copying the values, starting at index 6:");
        mySourceHT.Values.CopyTo(myTargetArray, 6);

        // Выводим на экран значения массива
        PrintValues(myTargetArray, ' ');
    }

    public static void PrintValues(String[] myArr, char mySeparator)
    {
        for (int i = 0; i < myArr.Length; i++)
            Console.Write("{0}{1}", mySeparator, myArr[i]);
        Console.WriteLine();
    }
}
