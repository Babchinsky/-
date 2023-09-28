using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class Interface
{

    public PriceList priceList { get; set; }
    public ILog log { get; set; }
    public ISerialize serialize { get; set; }

    public Interface()
    {
        log = new ConsoleLog();
        serialize = new XmlSerialise();

    }
    public void ChangeSerialise()
    {
        Console.WriteLine("Choose 1-2 (1-json 2-xml)");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1: serialize = new JsonSerialise(); break;
            case 2: serialize = new XmlSerialise(); break;

            default: Console.WriteLine("Error"); break;
        }
    }
    public void ChangeLog()
    {
        Console.WriteLine("Choose 1-3 (1-console 2-xmllog 3-filelog)");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1: log = new ConsoleLog(); break;
            case 3: log = new FileLog(); break;
            default: Console.WriteLine("Error"); break;
        }
    }
    public void Print()
    {

        priceList.Print(log);
    }
    public void Add()
    {
        Console.WriteLine("Choose 1-3 (1-Flash 2-HDD 3-DVD)");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1: priceList.Add(new Flash("Samsung", "A500", "KSDF123", 128, 3, 400)); break;
            case 2: priceList.Add(new HDD("Samsung", "A500", "FDSDF", 512, 3, 7200)); break;
            case 3: priceList.Add(new DVD("Samsung", "A500", "SDDFS", 40, 3, 900)); ; break;
            default: Console.WriteLine("Error"); break;
        }

    }

    public void AddMoreInfo()
    {
        //Метод add перенаправляет нас сюда и тут мы добовляем все поля для hdd flash dvd
    }
    public void Find()
    {
        Console.WriteLine("What you want to find ?");
        string Request = Console.ReadLine();
        priceList.Find(Request, log);


    }
    public void Save()
    {
        Console.WriteLine("TypeFile name");
        string filename = Console.ReadLine();

        priceList.Save(serialize, filename);
    }
    public void Load()
    {
        Console.WriteLine("TypeFile name");
        string filename = Console.ReadLine();

        priceList.Load(serialize, filename);
    }

    public void Edit()
    {
        try
        {
            Console.WriteLine($"What you want to delete [1-{priceList.list.Count}]");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type what field you want to change");
            string field = Console.ReadLine();
            Console.WriteLine("Type what new you want");
            string NewItem = Console.ReadLine();
            priceList.Edit(field, NewItem, i - 1);
        }
        catch (Exception ex) { Console.WriteLine("Error wrong "); }

    }
    public void Remove()
    {
        try
        {




            Console.WriteLine($"What you want to delete [1-{priceList.list.Count}]");
            int i = Convert.ToInt32(Console.ReadLine());
            priceList.Remove(priceList.list[i - 1]);
        }
        catch (Exception)
        {

            Console.WriteLine("Invalid numb");
        }
    }
}
