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
