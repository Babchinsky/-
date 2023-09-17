using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

public interface ISerialize
{
    void Save(List<Storage> storages, string filename);
    List<Storage> Load(string filename);
}

public class JsonSerialise : ISerialize
{

    public List<Storage> Load(string filename)
    {
        List<Storage> ls = new List<Storage>();
        var storage = new Storage[1];

        FileStream stream = new FileStream("device2.json", FileMode.Open);
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Storage[]));
        storage = (Storage[])jsonFormatter.ReadObject(stream);
        for (int i = 0; i < storage.Length; i++)
        {
            ls.Add(storage[i]);

        }
        Console.WriteLine();
        stream.Close();
        return ls;
    }

    public void Save(List<Storage> storages, string filename)
    {


        var storage = new Storage[3];


        FileStream stream = new FileStream("device2.json", FileMode.Create);
        DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Storage[]));
        jsonFormatter.WriteObject(stream, storages.ToArray());

        stream.Close();
        Console.WriteLine("Сериализация успешно выполнена!");
    }
}
public class XmlSerialise : ISerialize
{
    public List<Storage> Load(string filename)
    {
        List<Storage> ls = new List<Storage>();
        var storage = new Storage[1];
        FileStream stream = new FileStream("device2.xml", FileMode.Open);
        XmlSerializer jsonFormatter = new XmlSerializer(typeof(Storage[]));
        storage = (Storage[])jsonFormatter.Deserialize(stream);
        for (int i = 0; i < storage.Length; i++)
        {
            ls.Add(storage[i]);

        }
        Console.WriteLine();
        stream.Close();
        return ls;
    }

    public void Save(List<Storage> storages, string filename)
    {
        FileStream stream = new FileStream("device2.xml", FileMode.Create);
        XmlSerializer jsonFormatter = new XmlSerializer(typeof(Storage[]));
        jsonFormatter.Serialize(stream, storages.ToArray());

        stream.Close();
        Console.WriteLine("Сериализация успешно выполнена!");
    }


}
