using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace _1_lab_07._03._2023_Ex2
{
    public class HumanCollection
    {
        public List<Human> people;

        public HumanCollection()
        {
            people = new List<Human>();
        }

        public void Add(Human human)
        {
            people.Add(human);
        }

        // метод для сохранения данных в XML-файл
        public void SaveToXml(string fileName)
        {
            // создаем сериализатор
            XmlSerializer serializer = new XmlSerializer(typeof(HumanCollection));

            // открываем поток для записи в файл
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                // сериализуем данные
                serializer.Serialize(streamWriter, this);
            }
        }

        // метод для чтения данных из XML-файла
        public static HumanCollection LoadFromXml(string fileName)
        {
            // создаем сериализатор
            XmlSerializer serializer = new XmlSerializer(typeof(HumanCollection));

            // открываем поток для чтения из файла
            using (StreamReader streamReader = new StreamReader(fileName))
            {
                // десериализуем данные
                return (HumanCollection)serializer.Deserialize(streamReader);
            }
        }

        public override string ToString()
        {
            string buf = string.Empty;

            foreach (Human human in people)
            {
                buf += human.Output() + "\n";
            }
            return buf;
        }
    }
}
