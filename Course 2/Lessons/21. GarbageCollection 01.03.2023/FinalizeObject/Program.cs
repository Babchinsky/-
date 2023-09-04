using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizeObject
{
    // В .NET существует два типа ресурсов: управляемые и неуправляемые. 
    // К неуправляемым ресурсам относятся только «сырые» ресурсы, типа IntPtr, дескрипторы сокетов или файлов.
    // Если же этот ресурс упаковали в объект, захватывающий его в конструкторе и освобождающий в методе Dispose, 
    // то такой ресурс уже является управляемым. 
    // По сути, управляемые ресурсы – это «умные оболочки» для неуправляемых ресурсов, для освобождения которых 
    // не нужно вызывать какие-то функции, а достаточно вызвать метод Dispose интерфейса IDisposable
    class FinalizeObject
    {
        public int id { get; set; }

        public FinalizeObject(int id)
        {
            this.id = id;
        }

        ~FinalizeObject()
        {
            Console.WriteLine("Объект №{0} уничтожен", id);
            Console.Beep();
            // Освобождаем неуправляемые ресурсы
        }

        /*        
        При очистке сборщик мусора вызывает не деструктор, а метод Finalize класса FinalizeObject
         Метод Finalize уже определен в базовом для всех типов классе Object, однако данный метод нельзя переопределить. 
         И фактическая его реализация происходит через создание деструктора.

        protected override void Finalize()
        {
            try
            {
                // здесь идут инструкции деструктора
            }
            finally
            {
                base.Finalize();
            }
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            FinalizeObject[] obj = new FinalizeObject[30];
            for (int i = 0; i < 30; i++)
                obj[i] = new FinalizeObject(i);
            Console.WriteLine("Создано 30 объектов!");
            Console.Read();
            // После завершения приложения  будет активирована сборка мусора, 
            // которая удалит 30 объектов класса FinalizeObject, при этом запустится деструктор.
        }
    }
}
