﻿using System;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        List<string> dinosaurs = new List<string>();

        dinosaurs.Add("Tyrannosaurus");
        dinosaurs.Add("Amargasaurus");
        dinosaurs.Add("Mamenchisaurus");
        dinosaurs.Add("Brachiosaurus");
        dinosaurs.Add("Deinonychus");
        dinosaurs.Add("Tyrannosaurus");
        dinosaurs.Add("Compsognathus");

        Console.WriteLine();
        foreach (string dinosaur in dinosaurs)
        {
            Console.WriteLine(dinosaur);
        }

        Console.WriteLine("\nLastIndexOf(\"Tyrannosaurus\"): {0}",
            dinosaurs.LastIndexOf("Tyrannosaurus"));

        Console.WriteLine("\nLastIndexOf(\"Tyrannosaurus\", 3): {0}",
            dinosaurs.LastIndexOf("Tyrannosaurus", 3));

        Console.WriteLine("\nLastIndexOf(\"Tyrannosaurus\", 4, 4): {0}",
            dinosaurs.LastIndexOf("Tyrannosaurus", 4, 4));
    }
}
