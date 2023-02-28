using System;
using System.Collections;
public class SamplesStack
{

    public static void Main()
    {
		// Создаём и инициализируем новый стек
        Stack mySourceQ = new Stack();
        mySourceQ.Push("barn");
        mySourceQ.Push("the");
        mySourceQ.Push("in");
        mySourceQ.Push("cats");
        mySourceQ.Push("napping");
        mySourceQ.Push("three");

        // Создаем массив размером 15 элементов для хранения объектов типа String 
        Array myTargetArray = Array.CreateInstance(typeof(String), 15);
        myTargetArray.SetValue("The", 0);
        myTargetArray.SetValue("quick", 1);
        myTargetArray.SetValue("brown", 2);
        myTargetArray.SetValue("fox", 3);
        myTargetArray.SetValue("jumped", 4);
        myTargetArray.SetValue("over", 5);
        myTargetArray.SetValue("the", 6);
        myTargetArray.SetValue("lazy", 7);
        myTargetArray.SetValue("dog", 8);

        Console.WriteLine("The target Array contains the following (before and after copying):");
		// отображаем исходный массив
        PrintValues(myTargetArray, ' ');

        // Копируем элементы стека в массив, начиная с индекса 6
        mySourceQ.CopyTo(myTargetArray, 6);
		
		// отображаем массив после изменений
        PrintValues(myTargetArray, ' ');

        // Копируем элементы стека в новый массив
        Object[] myStandardArray = mySourceQ.ToArray();

        // Отображаем элементы массива
        Console.WriteLine("The new standard array contains the following:");
        PrintValues(myStandardArray, ' ');

    }


    public static void PrintValues(Array myArr, char mySeparator)
    {
        foreach (Object myObj in myArr)
        {
            Console.Write("{0}{1}", mySeparator, myObj);
        }
        Console.WriteLine();
    }

}
