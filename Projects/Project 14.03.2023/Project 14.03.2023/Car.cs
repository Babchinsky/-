using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_14._03._2023
{
    internal class Car
    {
        string name;
        int year;

        public Car()
        {
            LogManager.GetCurrentClassLogger().Info("Объект класса Car создан");
        }

        public Car(string name, int year)
        {
            this.name = name;
            this.year = year;
            LogManager.GetCurrentClassLogger().Info($"Объект класса Car ({name}, {year}) создан");
        }
    }
}
