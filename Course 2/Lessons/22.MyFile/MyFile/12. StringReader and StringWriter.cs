// Демонстрация использования классов StringReader  и StringWriter.

using System;
using System.IO;

class StrRdrDemo
{
    public static void Main()
    {
        try
        {
            // Создаем объект класса StringWriter.
            StringWriter strwtr = new StringWriter();
            // Записываем данные в StringWriter-объект.
            for (int i = 0; i < 10; i++)
                strwtr.WriteLine("Значение i равно: " + i);
            // Создаем объект класса StringReader.
            StringReader strrdr = new StringReader(strwtr.ToString());
            // Теперь считываем данные из StringReader-объекта.
            string str;
            while ((str = strrdr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
