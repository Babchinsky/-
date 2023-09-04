using System;
using System.Collections;
public class SamplesStack
{

    public static void Main()
    {

        // Создаём и инициализируем новый стек
        Stack myStack = new Stack();
        myStack.Push("fox");
        myStack.Push("brown");
        myStack.Push("quick");
        myStack.Push("The");
		
       // Отображаем стек
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');

        // Удаляем элемент из стека
        Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

        // Отображаем стек
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');

        // Удаляем элемент из стека
        Console.WriteLine("(Pop)\t\t{0}", myStack.Pop());

        // Отображаем стек
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');

        // Подсматриваем в вершину стека, не удаляя элемент
        Console.WriteLine("(Peek)\t\t{0}", myStack.Peek());

         // Отображаем стек
        Console.Write("Stack values:");
        PrintValues(myStack, '\t');
    }


    public static void PrintValues(IEnumerable myCollection, char mySeparator)
    {
        foreach (Object obj in myCollection)
            Console.Write("{0}{1}", mySeparator, obj);
        Console.WriteLine();
    }

}
