using System;
using System.Collections.Generic;
using System.Linq;

// Класс для хранения списка носителей информации
public class PriceList
{
    private List<StorageDevice> storageDevices = new List<StorageDevice>();
    private readonly ILog log;
    private readonly ISerialize<StorageDevice> serializer;

    public PriceList(ILog log, ISerialize<StorageDevice> serializer)
    {
        this.log = log;
        this.serializer = serializer;
    }

    public void AddStorageDevice(StorageDevice device)
    {
        storageDevices.Add(device);
        log.Print($"Добавлен носитель информации: {device.Name}");
    }

    public void RemoveStorageDevice(StorageDevice device)
    {
        storageDevices.Remove(device);
        log.Print($"Удален носитель информации: {device.Name}");
    }

    public void PrintStorageDevices()
    {
        foreach (var device in storageDevices)
        {
            device.GenerateReport();
            log.Print($"Носитель информации: {device.Name}");
        }
    }

    public void SaveData(string filePath)
    {
        serializer.Save(storageDevices, filePath);
        log.Print($"Данные сохранены в файл: {filePath}");
    }

    public void LoadData(string filePath)
    {
        storageDevices = serializer.Load(filePath);
        log.Print($"Данные загружены из файла: {filePath}");
    }

    // Метод для поиска носителей информации по критерию
    public List<StorageDevice> GetDevicesByCriteria(string criteria)
    {
        criteria = criteria.ToLower(); // Преобразуйте критерий в нижний регистр для сравнения

        return storageDevices.FindAll(device =>
            device.Manufacturer.ToLower().Contains(criteria) ||
            device.Model.ToLower().Contains(criteria) ||
            device.Name.ToLower().Contains(criteria)
        );
    }
}

