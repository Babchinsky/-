using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Project_14._03._2023
{
    internal class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            logger.Debug("Ошибка ввода данных");
            logger.Info("Необходимо ввести данные в диапазоне от 0 до 100");

            Car a = new Car();
            Car b = new Car("Audi", 2002);
        }
    }
}
