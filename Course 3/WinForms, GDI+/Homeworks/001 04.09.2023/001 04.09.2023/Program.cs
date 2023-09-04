using System;

// Базовый класс "Носитель информации"
public abstract class StorageDevice
{
    protected string Manufacturer { get; set; }
    protected string Model { get; set; }
    protected string Name { get; set; }
    protected int CapacityGB { get; set; }
    protected int Quantity { get; set; }

    protected StorageDevice(string manufacturer, string model, string name, int capacityGB, int quantity)
    {
        Manufacturer = manufacturer;
        Model = model;
        Name = name;
        CapacityGB = capacityGB;
        Quantity = quantity;
    }

    // Виртуальный метод для формирования отчёта
    public virtual void GenerateReport()
    {
        Console.WriteLine($"Производитель: {Manufacturer}");
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Наименование: {Name}");
        Console.WriteLine($"Ёмкость: {CapacityGB} ГБ");
        Console.WriteLine($"Количество: {Quantity}");
    }

    // Виртуальные методы для загрузки и сохранения данных
    public virtual void LoadData()
    {
        Console.WriteLine("Загрузка данных...");
    }

    public virtual void SaveData()
    {
        Console.WriteLine("Сохранение данных...");
    }
}

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

class Program
{
    static void Main(string[] args)
    {
        // Пример использования
        StorageDevice flashMemory = new Flash("Kingston", "DataTraveler", "Flash Drive", 64, 10, 150);
        StorageDevice removableHDD = new HDD("Seagate", "Backup Plus", "External HDD", 2000, 5, 7200);
        StorageDevice dvdDisk = new DVD("Sony", "DVD-R", "Blank DVD", 4, 20, 16);

        Console.WriteLine("Отчёт о Flash-памяти:");
        flashMemory.GenerateReport();
        Console.WriteLine();

        Console.WriteLine("Отчёт о съемном HDD:");
        removableHDD.GenerateReport();
        Console.WriteLine();

        Console.WriteLine("Отчёт о DVD-диске:");
        dvdDisk.GenerateReport();
    }
}
