using System;
using System.Collections.Generic;
using System.IO;

//Класс для JSON-сериализации данных
public class JSONSerialize<T> : ISerialize<T>
{
    public void Save(List<T> data, string filePath)
    {
        string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
        File.WriteAllText(filePath, json);
    }

    public List<T> Load(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);
        }
        return new List<T>();
    }
}
