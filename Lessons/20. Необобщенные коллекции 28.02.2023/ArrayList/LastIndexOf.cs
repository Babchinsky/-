using System;
using System.Collections;
public class SamplesArrayList
{

    public static void Main()
    {

        // Creates and initializes a new ArrayList with three elements of the same value.
        ArrayList myAL = new ArrayList();
        myAL.Add("the");
        myAL.Add("quick");
        myAL.Add("brown");
        myAL.Add("fox");
        myAL.Add("jumps");
        myAL.Add("over");
        myAL.Add("the");
        myAL.Add("lazy");
        myAL.Add("dog");
        myAL.Add("in");
        myAL.Add("the");
        myAL.Add("barn");

        // Displays the values of the ArrayList.
        Console.WriteLine("The ArrayList contains the following values:");
        PrintIndexAndValues(myAL);

        // Searches for the last occurrence of the duplicated value.
        String myString = "the";
        int myIndex = myAL.LastIndexOf(myString);
        Console.WriteLine("The last occurrence of \"{0}\" is at index {1}.", myString, myIndex);

        // Searches for the last occurrence of the duplicated value in the first section of the ArrayList.
        myIndex = myAL.LastIndexOf(myString, 8);
        Console.WriteLine("The last occurrence of \"{0}\" between the start and index 8 is at index {1}.", myString, myIndex);

        // Searches for the last occurrence of the duplicated value in a section of the ArrayList.  Note that the start index is greater than the end index because the search is done backward.
        myIndex = myAL.LastIndexOf(myString, 10, 6);
        Console.WriteLine("The last occurrence of \"{0}\" between index 10 and index 5 is at index {1}.", myString, myIndex);
    }

    public static void PrintIndexAndValues(IEnumerable myList)
    {
        int i = 0;
        foreach (Object obj in myList)
            Console.WriteLine("   [{0}]:    {1}", i++, obj);
        Console.WriteLine();
    }

}
