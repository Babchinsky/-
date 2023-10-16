//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//public class DataService : IDataService
//{
//    public void SaveContacts(List<Contact> contacts, string filePath)
//    {
//        // Реализация сохранения данных в файл
//        // В данном примере используется JSON для простоты
//        string jsonData = JsonConvert.SerializeObject(contacts);
//        File.WriteAllText(filePath, jsonData);
//    }

//    public List<Contact> LoadContacts(string filePath)
//    {
//        // Реализация загрузки данных из файла
//        if (File.Exists(filePath))
//        {
//            string jsonData = File.ReadAllText(filePath);
//            return JsonConvert.DeserializeObject<List<Contact>>(jsonData);
//        }
//        return new List<Contact>();
//    }
//}
