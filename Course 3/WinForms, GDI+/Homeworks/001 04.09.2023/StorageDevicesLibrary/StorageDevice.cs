using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageDevicesLibrary
{
    // Базовый класс Носитель информации
    public abstract class StorageDevice
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public int CapacityGB { get; set; }
        public int Quantity { get; set; }

        protected StorageDevice(string manufacturer, string model, string name, int capacityGB, int quantity)
        {
            Manufacturer = manufacturer;
            Model = model;
            Name = name;
            CapacityGB = capacityGB;
            Quantity = quantity;
        }

        // Виртуальный метод для формирования отчёта
        public virtual void Print()
        {
            Console.WriteLine($"Производитель: {Manufacturer}");
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Наименование: {Name}");
            Console.WriteLine($"Ёмкость: {CapacityGB} ГБ");
            Console.WriteLine($"Количество: {Quantity}");
        }
    }

    // Класс Flash-память
    public class Flash : StorageDevice
    {
        public int UsbSpeed { get; set; }

        public Flash(string manufacturer, string model, string name, int capacityGB, int quantity, int usbSpeed)
            : base(manufacturer, model, name, capacityGB, quantity)
        {
            UsbSpeed = usbSpeed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Скорость USB: {UsbSpeed} Мб/с");
        }
    }

    // Класс DVD-диск
    public class DVD : StorageDevice
    {
        public int WriteSpeed { get; set; }

        public DVD(string manufacturer, string model, string name, int capacityGB, int quantity, int writeSpeed)
            : base(manufacturer, model, name, capacityGB, quantity)
        {
            WriteSpeed = writeSpeed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Скорость записи: {WriteSpeed} Мб/с");
        }
    }

    // Класс съемный HDD
    public class HDD : StorageDevice
    {
        public int SpindleSpeed { get; set; }

        public HDD(string manufacturer, string model, string name, int capacityGB, int quantity, int spindleSpeed)
            : base(manufacturer, model, name, capacityGB, quantity)
        {
            SpindleSpeed = spindleSpeed;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Скорость вращения шпинделя: {SpindleSpeed} об/мин");
        }
    }
}
