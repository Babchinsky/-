using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс для печати в файл
public class FileLog : ILog
{
    private readonly string filePath;

    public FileLog(string filePath)
    {
        this.filePath = filePath;
    }

    public void Print(string message)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(message);
        }
    }
}
