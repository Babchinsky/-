using System;
using System.Collections.Generic;

// Класс для работы с носителями информации
public class StorageManager
{
    private List<StorageDevice> storageDevices = new List<StorageDevice>();

    public void AddStorageDevice()
    {
        Console.WriteLine("Выберите тип носителя информации:");
        Console.WriteLine("1. Flash-память");
        Console.WriteLine("2. Съемный HDD");
        Console.WriteLine("3. DVD-диск");

        int typeChoice = int.Parse(Console.ReadLine());

        Console.Write("Производитель: ");
        string manufacturer = Console.ReadLine();

        Console.Write("Модель: ");
        string model = Console.ReadLine();

        Console.Write("Наименование: ");
        string name = Console.ReadLine();

        Console.Write("Ёмкость (в ГБ): ");
        int capacityGB = int.Parse(Console.ReadLine());

        Console.Write("Количество: ");
        int quantity = int.Parse(Console.ReadLine());

        StorageDevice newDevice = null;

        switch (typeChoice)
        {
            case 1:
                Console.Write("Скорость USB (Мб/с): ");
                int usbSpeed = int.Parse(Console.ReadLine());
                newDevice = new Flash(manufacturer, model, name, capacityGB, quantity, usbSpeed);
                break;
            case 2:
                Console.Write("Скорость вращения шпинделя (об/мин): ");
                int spindleSpeed = int.Parse(Console.ReadLine());
                newDevice = new HDD(manufacturer, model, name, capacityGB, quantity, spindleSpeed);
                break;
            case 3:
                Console.Write("Скорость записи (Мб/с): ");
                int writeSpeed = int.Parse(Console.ReadLine());
                newDevice = new DVD(manufacturer, model, name, capacityGB, quantity, writeSpeed);
                break;
            default:
                Console.WriteLine("Неверный выбор типа носителя информации.");
                return;
        }

        storageDevices.Add(newDevice);
        Console.WriteLine("Носитель информации успешно добавлен.");
    }

    public void RemoveStorageDevice()
    {
        Console.WriteLine("Введите критерий для удаления носителя информации (например, производитель):");
        //    string criteria = Console.ReadLine();

        //    var devicesToRemove = storageDevices.Where(device =>
        //        device.Manufacturer.Equals(criteria, StringComparison.OrdinalIgnoreCase) ||
        //        device.Model.Equals(criteria, StringComparison.OrdinalIgnoreCase) ||
        //        device.Name.Equals(criteria, StringComparison.OrdinalIgnoreCase)
        //    ).ToList();

        //    if (devicesToRemove.Count == 0)
        //    {
        //        Console.WriteLine("Носители информации не найдены по заданному критерию.");
        //        return;
        //    }

        //    Console.WriteLine("Найдены следующие носители информации:");
        //    PrintStorageDevices(devicesToRemove);

        //    Console.Write("Введите номер носителя для удаления: ");
        //    int indexToRemove = int.Parse(Console.ReadLine());

        //    if (indexToRemove >= 0 && indexToRemove < devicesToRemove.Count)
        //    {
        //        storageDevices.Remove(devicesToRemove[indexToRemove]);
        //        Console.WriteLine("Носитель информации успешно удален.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Неверный номер носителя для удаления.");
        //    }
    }

    public void PrintStorageDevices()
    {
        Console.WriteLine("Список носителей информации:");
        for (int i = 0; i < storageDevices.Count; i++)
        {
            Console.WriteLine($"Носитель {i + 1}:");
            storageDevices[i].GenerateReport();
            Console.WriteLine();
        }
    }
}
