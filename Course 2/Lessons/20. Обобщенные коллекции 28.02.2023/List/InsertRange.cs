using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        string[] input = { "Brachiosaurus", 
                           "Amargasaurus", 
                           "Mamenchisaurus" };

        List<string> dinosaurs = new List<string>(input);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
             
        input = new string[] { "Tyrannosaurus", 
                               "Deinonychus", 
                               "Velociraptor"};

        Console.WriteLine("\nInsertRange(1, input)");
        dinosaurs.InsertRange(1, input);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

      
    }
}

