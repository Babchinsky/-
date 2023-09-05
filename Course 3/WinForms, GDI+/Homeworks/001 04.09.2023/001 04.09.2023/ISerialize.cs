using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Интерфейс для сериализации данных
public interface ISerialize<T>
{
    void Save(List<T> data, string filePath);
    List<T> Load(string filePath);
}

