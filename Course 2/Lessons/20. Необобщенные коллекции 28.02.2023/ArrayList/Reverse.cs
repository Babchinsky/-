using System;
using System.Collections;
public class SamplesArrayList
{

    public static void Main()
    {

        // Creates and initializes a new ArrayList.
        ArrayList myAL = new ArrayList();
        myAL.Add("The");
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");
        myAL.Add("jumps");
        myAL.Add("over");
        myAL.Add("the");
        myAL.Add("lazy");
        myAL.Add("dog");

        // Displays the values of the ArrayList.
        Console.WriteLine("The ArrayList initially contains the following values:");
        PrintValues(myAL);

        // Reverses the sort order of the values of the ArrayList.
        myAL.Reverse();

        // Displays the values of the ArrayList.
        Console.WriteLine("After reversing:");
        PrintValues(myAL);

        myAL.Reverse(1, 3);

        // Displays the values of the ArrayList.
        Console.WriteLine("After reversing:");
        PrintValues(myAL);

    }

    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
            Console.WriteLine("   {0}", obj);
        Console.WriteLine();
    }

}
