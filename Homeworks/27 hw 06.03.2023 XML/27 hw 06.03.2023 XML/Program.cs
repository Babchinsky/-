using System;
using System.Xml;

class Program
{
    static XmlElement CreateOrder(XmlDocument doc, string id, string customer)
    {
        XmlElement order = doc.CreateElement("Order");
        order.SetAttribute("id", id);
        order.SetAttribute("customer", customer);
        return order;
    }

    static void CreateProduct(XmlDocument doc, XmlElement order, string name, string price)
    {
        XmlElement product = doc.CreateElement("Product");
        product.SetAttribute("name", name);
        product.SetAttribute("price", price);
        order.AppendChild(product);
    }




    static void Main(string[] args)
    {
        // Создаем новый XML-документ и указываем его корневой элемент
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("Orders");
        doc.AppendChild(root);

        // Создаем несколько заказов с товарами и добавляем их в XML-документ
        XmlElement order1 = CreateOrder(doc, "1", "John Doe");
        CreateProduct(doc, order1, "Product A", "10.00");
        CreateProduct(doc, order1, "Product B", "20.00");
        root.AppendChild(order1);

        XmlElement order2 = CreateOrder(doc, "2", "Jane Smith");
        CreateProduct(doc, order2, "Product C", "30.00");
        CreateProduct(doc, order2, "Product D", "40.00");
        CreateProduct(doc, order2, "Product E", "50.00");
        root.AppendChild(order2);

        // Создаем XML-файл и сохраняем в него информацию о заказах
        using (XmlTextWriter writer = new XmlTextWriter("orders.xml", null))
        {
            writer.Formatting = Formatting.Indented;
            doc.WriteTo(writer);
        }

        // Читаем информацию из XML-файла и выводим ее на экран
        using (XmlTextReader reader = new XmlTextReader("orders.xml"))
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Order")
                {
                    Console.WriteLine("Order ID: {0}", reader.GetAttribute("id"));
                    Console.WriteLine("Customer: {0}", reader.GetAttribute("customer"));
                }
                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "Product")
                {
                    Console.WriteLine("Product: {0}", reader.GetAttribute("name"));
                    Console.WriteLine("Price: {0}", reader.GetAttribute("price"));
                }
            }
        }
    }
}
