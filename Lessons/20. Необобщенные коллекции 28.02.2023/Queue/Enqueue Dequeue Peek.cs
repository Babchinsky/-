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

        // Отображаем очередь
        Console.Write("Queue values:");
        PrintValues(myQ);

        // Удаляем элемент, находящийся в начале очереди
        Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

        // Отображаем очередь
        Console.Write("Queue values:");
        PrintValues(myQ);

        // Удаляем элемент, находящийся в начале очереди
        Console.WriteLine("(Dequeue)\t{0}", myQ.Dequeue());

        // Отображаем очередь
        Console.Write("Queue values:");
        PrintValues(myQ);

        // Получим первый элемент из очереди, не удаляя его
        Console.WriteLine("(Peek)   \t{0}", myQ.Peek());

        // Отображаем очередь
        Console.Write("Queue values:");
        PrintValues(myQ);
    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }
}
