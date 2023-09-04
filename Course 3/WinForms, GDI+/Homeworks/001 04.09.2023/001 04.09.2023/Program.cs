using System;

class Program
{
    static void Main(string[] args)
    {
        StorageManager storageManager = new StorageManager();

        while (true)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Добавить носитель информации");
            Console.WriteLine("2. Удалить носитель информации");
            Console.WriteLine("3. Вывести список носителей информации");
            Console.WriteLine("4. Выход");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    storageManager.AddStorageDevice();
                    break;
                case 2:
                    storageManager.RemoveStorageDevice();
                    break;
                case 3:
                    storageManager.PrintStorageDevices();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }
}
