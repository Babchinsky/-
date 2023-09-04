using System;
using System.Collections;
public class SamplesQueue
{

    public static void Main()
    {

        // Создаём и инициализируем очередь
        Queue mySourceQ = new Queue();
        mySourceQ.Enqueue("three");
        mySourceQ.Enqueue("napping");
        mySourceQ.Enqueue("cats");
        mySourceQ.Enqueue("in");
        mySourceQ.Enqueue("the");
        mySourceQ.Enqueue("barn");

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

        //Выводим массив на экран
        Console.WriteLine("The target Array contains the following (before and after copying):");
        PrintValues(myTargetArray, ' ');

        // Копируем элементы очереди в массив, начиная с индекса 6
        mySourceQ.CopyTo(myTargetArray, 6);

        //Выводим массив на экран
        PrintValues(myTargetArray, ' ');

        // Копируем элементы очереди в новый массив
        Object[] myStandardArray = mySourceQ.ToArray();

        // отображаем массив
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
