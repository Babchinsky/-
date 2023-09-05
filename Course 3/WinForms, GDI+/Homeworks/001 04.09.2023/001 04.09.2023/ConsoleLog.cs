using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс для печати в консоль
public class ConsoleLog : ILog
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}
