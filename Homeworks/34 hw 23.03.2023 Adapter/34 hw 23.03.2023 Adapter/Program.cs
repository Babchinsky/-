namespace _34_hw_23._03._2023_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта класса Original
            Original original = new Original();

            // Создание объекта класса Client и передача ему объекта Original через интерфейс ITarget
            Client client = new Client(new OriginalToClientAdapter(original));

            // Вызов методов ClientDouble(), ClientInt() и ClientChar() объекта client
            client.ClientDouble(3.14);
            client.ClientInt(10);
            client.ClientChar('A');
        }
    }
}
