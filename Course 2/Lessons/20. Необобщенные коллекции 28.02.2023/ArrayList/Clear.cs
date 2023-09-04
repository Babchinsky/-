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
        myAL.Add("jumped");

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("Initially,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Trim the ArrayList.
        myAL.TrimToSize();

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("After TrimToSize,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Clear the ArrayList.
        myAL.Clear();

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("After Clear,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);

        // Trim the ArrayList again.
        myAL.TrimToSize();

        // Displays the count, capacity and values of the ArrayList.
        Console.WriteLine("After the second TrimToSize,");
        Console.WriteLine("   Count    : {0}", myAL.Count);
        Console.WriteLine("   Capacity : {0}", myAL.Capacity);
        Console.Write("   Values:");
        PrintValues(myAL);
    }

    public static void PrintValues(IEnumerable myList)
    {
        foreach (Object obj in myList)
            Console.Write("   {0}", obj);
        Console.WriteLine();
    }

}
