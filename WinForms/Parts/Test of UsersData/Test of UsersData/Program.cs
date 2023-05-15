using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public class Event
{
    public DateTime Date { get; set; }
    public string Name { get; set; }

    public Event() { }
    public Event(DateTime date, string name)
    {
        Date = date;
        Name = name;
    }
}

public class EventFileManager
{
    private string filePath;

    public EventFileManager(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Event> ReadFile()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            List<Event> events = JsonConvert.DeserializeObject<List<Event>>(json);
            return events;
        }
        else
        {
            return new List<Event>();
        }
    }

    public void WriteToFile(List<Event> events)
    {
        string json = JsonConvert.SerializeObject(events, Formatting.Indented);
        File.WriteAllText(filePath, json);
        Console.WriteLine("Список событий успешно записан в файл JSON.");
    }


    public void AddEvent(Event selEvent)
    {
        List<Event> events = ReadFile();

        events.Add(selEvent);
        string json = JsonConvert.SerializeObject(events, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    
    public void RemoveEvent(Event eventToRemove)
    {
        List<Event> events = ReadFile();

        // Поиск события для удаления
        Event eventToDelete = events.FirstOrDefault(ev => ev.Date == eventToRemove.Date && ev.Name == eventToRemove.Name);

        if (eventToDelete != null)
        {
            events.Remove(eventToDelete);
            string json = JsonConvert.SerializeObject(events, Formatting.Indented);
            File.WriteAllText(filePath, json);
            //Console.WriteLine("Событие успешно удалено из JSON-файла.");
        }
        else
        {
            //Console.WriteLine("Событие не найдено в JSON-файле.");
        }
    }

    public bool IsEventExists(Event checkedEvent)
    {
        List<Event> events = ReadFile();
        foreach (Event curEvent in events)
        {
            if (curEvent.Name == checkedEvent.Name && curEvent.Date == checkedEvent.Date)
            {
                return true;
            }
        }
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string filePath = "events.json"; // Путь к JSON-файлу

        // Создаем экземпляр JsonFileManager с указанием пути к файлу
        EventFileManager jsonFileManager = new EventFileManager(filePath);

        // Чтение событий из файла

        //List<Event> events = new List<Event>();
        //events.Add(new Event(new DateTime(2025, 5,13), "School"));

        //jsonFileManager.WriteToFile(events);
        List<Event> events = jsonFileManager.ReadFile();

        //// Вывод существующих событий
        //Console.WriteLine("Существующие события:");
        //foreach (Event ev in events)
        //{
        //    Console.WriteLine($"Дата: {ev.Date}, Название: {ev.Name}");
        //}

        #region Добавление события в файл
        jsonFileManager.AddEvent(new Event(new DateTime(2025, 5, 13), "School"));
        #endregion


        #region Удаление события из файла
        //jsonFileManager.RemoveEvent(new Event(new DateTime(2025, 5, 13), "School"));
        #endregion

        //Console.WriteLine("Новое событие добавлено в файл.");

        //// Проверка существования события в файле
        //Event checkedEvent = new Event(newEventDate, newEventName);
        //bool isEventExists = jsonFileManager.IsEventExists(checkedEvent);
        //Console.WriteLine($"Событие {checkedEvent.Name} с датой {checkedEvent.Date} существует в файле: {isEventExists}");


        //Console.WriteLine("Событие удалено из файла.");

        //// Проверка существования события после удаления
        //isEventExists = jsonFileManager.IsEventExists(checkedEvent);
        //Console.WriteLine($"Событие {checkedEvent.Name} с датой {checkedEvent.Date} существует в файле: {isEventExists}");

        //Console.ReadLine();
    }
}
