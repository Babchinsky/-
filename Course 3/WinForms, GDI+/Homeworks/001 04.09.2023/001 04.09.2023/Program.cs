using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите способ логирования (1 - Консоль, 2 - Файл):");
        int logChoice = int.Parse(Console.ReadLine());
        ILog log = logChoice == 1 ? (ILog)new ConsoleLog() : (ILog)new FileLog("log.txt");

        Console.WriteLine("Выберите способ сериализации данных (1 - Бинарный, 2 - JSON):");
        int serializeChoice = int.Parse(Console.ReadLine());
        ISerialize<StorageDevice> serializer = serializeChoice == 1 ? (ISerialize<StorageDevice>)new BinarySerialize<StorageDevice>() : (ISerialize<StorageDevice>)new JSONSerialize<StorageDevice>();

        PriceList priceList = new PriceList(log, serializer);

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить носитель информации");
            Console.WriteLine("2. Удалить носитель информации");
            Console.WriteLine("3. Вывести список носителей информации");
            Console.WriteLine("4. Сохранить данные в файл");
            Console.WriteLine("5. Загрузить данные из файла");
            Console.WriteLine("6. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Выберите тип носителя информации (1 - Flash Memory, 2 - Removable HDD, 3 - DVD Disk):");
                    int deviceType = int.Parse(Console.ReadLine());

                    Console.Write("Введите производителя: ");
                    string manufacturer = Console.ReadLine();

                    Console.Write("Введите модель: ");
                    string model = Console.ReadLine();

                    Console.Write("Введите наименование: ");
                    string name = Console.ReadLine();

                    Console.Write("Введите ёмкость (в ГБ): ");
                    int capacityGB = int.Parse(Console.ReadLine());

                    Console.Write("Введите количество: ");
                    int quantity = int.Parse(Console.ReadLine());

                    StorageDevice newDevice = null;

                    switch (deviceType)
                    {
                        case 1:
                            Console.Write("Введите скорость USB: ");
                            int usbSpeed = int.Parse(Console.ReadLine());
                            newDevice = new Flash(manufacturer, model, name, capacityGB, quantity, usbSpeed);
                            break;
                        case 2:
                            Console.Write("Введите скорость вращения шпинделя: ");
                            int spindleSpeed = int.Parse(Console.ReadLine());
                            newDevice = new HDD(manufacturer, model, name, capacityGB, quantity, spindleSpeed);
                            break;
                        case 3:
                            Console.Write("Введите скорость записи: ");
                            int writeSpeed = int.Parse(Console.ReadLine());
                            newDevice = new DVD(manufacturer, model, name, capacityGB, quantity, writeSpeed);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор типа носителя информации.");
                            break;
                    }

                    if (newDevice != null) priceList.AddStorageDevice(newDevice);
                    
                    break;
                case 2:
                    // Удаление носителя информации
                    Console.WriteLine("Введите критерий для удаления носителя информации (например, производитель):");
                    string criteria = Console.ReadLine();

                    List<StorageDevice> devicesToDelete = priceList.GetDevicesByCriteria(criteria);

                    if (devicesToDelete.Count > 0)
                    {
                        foreach (var deviceToDelete in devicesToDelete)
                        {
                            priceList.RemoveStorageDevice(deviceToDelete);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Носитель информации, удовлетворяющий критерию '{criteria}', не найден.");
                    }
                    break;
                case 3:
                    // Вывод списка носителей информации
                    priceList.PrintStorageDevices();
                    break;
                case 4:
                    Console.Write("Введите путь к файлу для сохранения данных: ");
                    string saveFilePath = Console.ReadLine();

                    try
                    {
                        priceList.SaveData(saveFilePath);
                        Console.WriteLine($"Данные успешно сохранены в файл: {saveFilePath}");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Console.WriteLine("Ошибка: У вас нет разрешения на запись в указанный каталог или файл.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Произошла ошибка при сохранении данных: {ex.Message}");
                    }
                    break;

                case 5:
                    Console.Write("Введите путь к файлу для загрузки данных: ");
                    string loadFilePath = Console.ReadLine();
                    priceList.LoadData(loadFilePath);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}