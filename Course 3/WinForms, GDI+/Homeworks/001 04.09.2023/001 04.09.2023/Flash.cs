using System;

// Класс Flash-память
public class Flash : StorageDevice
{
    public int UsbSpeed { get; set; }

    public Flash(string manufacturer, string model, string name, int capacityGB, int quantity, int usbSpeed)
        : base(manufacturer, model, name, capacityGB, quantity)
    {
        UsbSpeed = usbSpeed;
    }

    public override void GenerateReport()
    {
        base.GenerateReport();
        Console.WriteLine($"Скорость USB: {UsbSpeed} Мб/с");
    }
}

