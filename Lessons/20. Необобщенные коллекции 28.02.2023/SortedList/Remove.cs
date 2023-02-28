using System;
using System.Collections;
public class SamplesSortedList
{

    public static void Main()
    {

        // Creates and initializes a new SortedList.
        SortedList mySL = new SortedList();
        mySL.Add("3c", "dog");
        mySL.Add("2c", "over");
        mySL.Add("1c", "brown");
        mySL.Add("1a", "The");
        mySL.Add("1b", "quick");
        mySL.Add("3a", "the");
        mySL.Add("3b", "lazy");
        mySL.Add("2a", "fox");
        mySL.Add("2b", "jumped");

        // Displays the SortedList.
        Console.WriteLine("The SortedList initially contains the following:");
        PrintKeysAndValues(mySL);

        // Removes the element with the key "3b".
        mySL.Remove("3b");

        // Displays the current state of the SortedList.
        Console.WriteLine("After removing \"lazy\":");
        PrintKeysAndValues(mySL);

        // Removes the element at index 5.
        mySL.RemoveAt(5);

        // Displays the current state of the SortedList.
        Console.WriteLine("After removing the element at index 5:");
        PrintKeysAndValues(mySL);
    }


    public static void PrintKeysAndValues(SortedList myList)
    {
        Console.WriteLine("\t-KEY-\t-VALUE-");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
        }
        Console.WriteLine();
    }
}