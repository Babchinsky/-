

using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[Serializable]

[KnownType(typeof(Flash))]
[KnownType(typeof(DVD))]
[KnownType(typeof(HDD))]
[XmlInclude(typeof(Flash))]
[XmlInclude(typeof(DVD))]
[XmlInclude(typeof(HDD))]
[DataContract]
// Базовый класс Носитель информации
public abstract class Storage
{
    [DataMember]
    public string Manufacturer { get; set; }
    [DataMember]
    public string Model { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public int CapacityGB { get; set; }
    [DataMember]
    public int Quantity { get; set; }

    [JsonConstructor]
    protected Storage(string manufacturer, string model, string name, int capacityGB, int quantity)
        {
            Manufacturer = manufacturer;
            Model = model;
            Name = name;
            CapacityGB = capacityGB;
            Quantity = quantity;
        }

        // Виртуальный метод для формирования отчёта
        public virtual void Print(ILog log)
        {
            string str = $"Производитель: {Manufacturer}\nМодель: {Model}\nНаименование: {Name}\nЁмкость: {CapacityGB} ГБ\nКоличество: {Quantity}";
            log.Print(str);
        }
    }

[Serializable]
[DataContract]
// Класс Flash-память
public class Flash : Storage
    {
        [DataMember]
        public int UsbSpeed { get; set; }

    [JsonConstructor]
    public Flash(string manufacturer, string model, string name, int capacityGB, int quantity, int usbSpeed)
            : base(manufacturer, model, name, capacityGB, quantity)
        {
            UsbSpeed = usbSpeed;
        }

        public override void Print(ILog log)
        {
            base.Print(log);
            string str = $"Скорость USB: {UsbSpeed} Мб/с";
            log.Print(str);
        }
    }

[Serializable]
[DataContract]
// Класс DVD-диск
public class DVD : Storage
{
    [DataMember]
    public int WriteSpeed { get; set; }


    [JsonConstructor]
    public DVD(string manufacturer, string model, string name, int capacityGB, int quantity, int writeSpeed)
            : base(manufacturer, model, name, capacityGB, quantity)
        {
            WriteSpeed = writeSpeed;
        }

        public override void Print(ILog log)
        {
            base.Print(log);
            string str = $"Скорость записи: {WriteSpeed} Мб/с";
            log.Print(str);
        }
    }

// Класс съемный HDD
public class HDD : Storage
    {
    [DataMember]
    public int SpindleSpeed { get; set; }

    [JsonConstructor]
    public HDD(string manufacturer, string model, string name, int capacityGB, int quantity, int spindleSpeed)
            : base(manufacturer, model, name, capacityGB, quantity)
        {
            SpindleSpeed = spindleSpeed;
        }

        public override void Print(ILog log)
        {
            base.Print(log);
            string str = $"Скорость вращения шпинделя: {SpindleSpeed} об/мин";
            log.Print(str);
        }
    }