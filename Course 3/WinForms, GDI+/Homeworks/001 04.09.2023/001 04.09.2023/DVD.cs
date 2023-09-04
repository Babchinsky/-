using System;

// Класс DVD-диск
public class DVD : StorageDevice
{
    public int WriteSpeed { get; set; }

    public DVD(string manufacturer, string model, string name, int capacityGB, int quantity, int writeSpeed)
        : base(manufacturer, model, name, capacityGB, quantity)
    {
        WriteSpeed = writeSpeed;
    }

    public override void GenerateReport()
    {
        base.GenerateReport();
        Console.WriteLine($"Скорость записи: {WriteSpeed} Мб/с");
    }
}
