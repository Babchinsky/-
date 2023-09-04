using System;
using System.Collections;
public class SamplesQueue
{

    public static void Main()
    {

        // Создаём и инициализируем очередь
        Queue myQ = new Queue();
        myQ.Enqueue("The");
        myQ.Enqueue("quick");
        myQ.Enqueue("brown");
        myQ.Enqueue("fox");
        myQ.Enqueue("jumped");

        // Отображаем количество элементов в очереди и элементы очереди
        Console.WriteLine("Initially,");
        Console.WriteLine("   Count    : {0}", myQ.Count);
        Console.Write("   Values:");
        PrintValues(myQ);

        // Очищаем очередь
        myQ.Clear();

        // Отображаем количество элементов в очереди и элементы очереди
        Console.WriteLine("After Clear,");
        Console.WriteLine("   Count    : {0}", myQ.Count);
        Console.Write("   Values:");
        PrintValues(myQ);

    }

    public static void PrintValues(Queue myQ)
    {
        foreach (Object myObj in myQ)
        {
            Console.Write("    {0}", myObj);
        }
        Console.WriteLine();
    }

}
