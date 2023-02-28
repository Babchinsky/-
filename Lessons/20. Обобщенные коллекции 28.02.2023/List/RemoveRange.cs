using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> dinosaurs = new List<string>();
        dinosaurs.Add("Compsognathus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Oviraptor");
        dinosaurs.Add("Velociraptor");
        dinosaurs.Add("Deinonychus");
        dinosaurs.Add("Dilophosaurus");
        dinosaurs.Add("Gallimimus");
        dinosaurs.Add("Triceratops");

        Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
        Console.WriteLine("\nRemoveRange(2, 2)");
        dinosaurs.RemoveRange(2, 2);

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }
    }
}

