using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    public static void Task1()
    {
        List<object> collection = new List<object>() { 1, "Hello", DateTime.Now };


        Thread thread = new Thread(() =>
        {
            foreach (object item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        });
        thread.Start();
    }

    class Bank
    {
        private int money;
        private string name;
        private int percent;
        private readonly object lockObject = new object();

        public Bank(int money, string name, int percent)
        {
            Money = money;
            Name = name;
            Percent = percent;
        }

        public int Money
        {
            get { return money; }
            set
            {
                lock (lockObject)
                {
                    money = value;
                    StartThread();
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                lock (lockObject)
                {
                    name = value;
                    StartThread();
                }
            }
        }

        public int Percent
        {
            get { return percent; }
            set
            {
                lock (lockObject)
                {
                    percent = value;
                    StartThread();
                }
            }
        }

        private void StartThread()
        {
            Thread thread = new Thread(() =>
            {
                string data = $"{DateTime.Now}: Money={money}, Name={name}, Percent={percent}";


                while (true)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter("log.txt", true))
                        {
                            // Ваш код записи в файл
                            writer.WriteLine(data);
                        }
                        break;
                    }
                    catch (IOException ex)
                    {
                        // Файл уже используется другим процессом
                        // Повторяем попытку через некоторое время
                        Thread.Sleep(100);
                    }
                }
            });
            thread.Start();
        }
    }


    public static void Task2()
    {
        Bank bank = new Bank(1800, "Monobank", 1);
    }

    static void Main()
    {
        //Task1();
        Task2();
    }
}
