using System;
using System.Collections;

public class SamplesStack
{

    public static void Main()
    {
        // Создаём и инициализируем новый стек
        Stack myStack = new Stack();
        myStack.Push("jumped");
        myStack.Push("fox");
        myStack.Push("brown");
        myStack.Push("quick");
        myStack.Push("The");
        // отображаем содержимое стека и количество элементов в стеке
        Console.WriteLine("Initially,");
        Console.WriteLine("   Count    : {0}", myStack.Count);
        Console.Write("   Values:");
        PrintValues(myStack);

        // Очищаем стек
        myStack.Clear();

         // отображаем содержимое стека и количество элементов в стеке
        Console.WriteLine("After Clear,");
        Console.WriteLine("   Count    : {0}", myStack.Count);
        Console.Write("   Values:");
        PrintValues(myStack);

    }

    public static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
            Console.Write("    {0}", obj);
        Console.WriteLine();
    }

}
