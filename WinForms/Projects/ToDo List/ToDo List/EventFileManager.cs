using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ToDo_List
{
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

        public void CreateEmptyFile()
        {
            File.WriteAllText(filePath, "");
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
}
