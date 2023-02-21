using System;
using System.Collections.Generic;


class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }
}

class Backpack
{
    public string Color { get; set; }
    public string Manufacturer { get; set; }
    public string Material { get; set; }
    public double Weight { get; set; }
    public double Capacity { get; set; }
    public List<Item> Contents { get; set; } = new List<Item>();

    public event Action<Item> Notify;

    public void AddItem(Item item)
    {
        if (item.Volume > Capacity - GetUsedVolume())
        {
            throw new Exception("Not enough space in the backpack.");
        }

        Contents.Add(item);
        Notify?.Invoke(item);
    }

    public double GetUsedVolume()
    {
        double usedVolume = 0;
        foreach (Item item in Contents)
        {
            usedVolume += item.Volume;
        }
        return usedVolume;
    }

    public override string ToString()
    {
        return $"Backpack ({Color}, {Manufacturer}, {Material}, {Weight} kg, {GetUsedVolume()}/{Capacity} L)";
    }
}