using System;
using System.Collections.Generic;
using System.IO;


// Класс для бинарной сериализации данных
public class BinarySerialize<T> : ISerialize<T>
{
    public void Save(List<T> data, string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            formatter.Serialize(fs, data);
        }
    }

    public List<T> Load(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (List<T>)formatter.Deserialize(fs);
            }
        }
        return new List<T>();
    }
}
