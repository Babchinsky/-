using System.Reflection;

[Serializable]
public class PriceList
{
    public List<Storage> list = new List<Storage>();

    public void Add(Storage addingStorage)
    {
        list.Add(addingStorage);
    }

    public void Remove(Storage removableStorage)
    {
        list.Remove(removableStorage);
    }

    public void Edit(string obj, string newItem, int id)
    {
        Type myType = typeof(Storage);
        PropertyInfo[] myField = myType.GetProperties();
        foreach (var fields in myField)
        {

            if (fields.Name.Contains(obj))
            {
                Console.WriteLine("Find By \t" + fields.Name + '\n' + '\n');
                fields.SetValue(list[id], newItem);
            }
        }
    }

    public void Find(string Request, ILog log)
    {
        foreach (var item in list)
        {
            Type myType = typeof(Storage);
            PropertyInfo[] myField = myType.GetProperties();
            foreach (var fields in myField)
            {

                if (fields.GetValue(item).ToString().Contains(Request))
                {
                    Console.WriteLine("Find By \t" + fields.Name + '\n' + '\n');
                    item.Print(log);
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
        }
    }

    public void Print(ILog log)
    {
        foreach (Storage storage in list)
        {
            storage.Print(log);
        }
    }

    public void Save(ISerialize serialize, string filename)
    {
        serialize.Save(list, filename);
    }

    public void Load(ISerialize serialize, string filename)
    {
        list = serialize.Load(filename);
    }
}
