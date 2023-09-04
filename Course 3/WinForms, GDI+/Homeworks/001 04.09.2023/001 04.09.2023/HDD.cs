using System;


// Класс съемный HDD
public class HDD : StorageDevice
{
    public int SpindleSpeed { get; set; }

    public HDD(string manufacturer, string model, string name, int capacityGB, int quantity, int spindleSpeed)
        : base(manufacturer, model, name, capacityGB, quantity)
    {
        SpindleSpeed = spindleSpeed;
    }

    public override void GenerateReport()
    {
        base.GenerateReport();
        Console.WriteLine($"Скорость вращения шпинделя: {SpindleSpeed} об/мин");
    }
}
