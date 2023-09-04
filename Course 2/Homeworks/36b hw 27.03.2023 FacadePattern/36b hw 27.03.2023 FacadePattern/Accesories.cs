using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36b_hw_27._03._2023_FacadePattern
{
    public class PowerUnit
    {
        public void On()
        {
            Console.WriteLine("Блок питания: подать питание");
        }
        public void PowerUpGPU()
        {
            Console.WriteLine("Блок питания: подать питание на видеокарту");
        }



        public void Off()
        {
            Console.WriteLine("Блок питания: выключение");
        }
    }
    public class GPU
    {
        public void On()
        {
            Console.WriteLine("Видеокарта: запуск");
        }
        public void Off()
        {
            Console.WriteLine("Видеокарта: вывести на монитор данные прощальное сообщение.");
        }
    }
    public class RAM
    {
        public void On() { }
        public void Off() { }
    }
    public class HDD
    {
        public void On() { }
        public void Off() { }
    }
    public class OpticalDrive
    {
        public void On() { }
        public void Off() { }
    }
    public class Sensors
    {
        public void On() 
        {
            Console.WriteLine("Датчики: проверить напряжение                 ");  
            Console.WriteLine("Датчики: проверить температуру в блоке питания");
            Console.WriteLine("Датчики: проверить температуру в видеокарте   ");
        }
        public void Off() 
        {
            Console.WriteLine("Датчики проверить напряжение");
        }
    }

}
