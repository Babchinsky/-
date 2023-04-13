using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5b_hw_12._04._2023
{
    public class ComputerComponent
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ComputerComponent(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
    public class ComputerComponents
    {
        public ComputerComponent[] arr;

        public void Add(ComputerComponent addedComponent)
        {
            // Увеличение размера массива до 4 элементов
            Array.Resize(ref arr, 4);

            // Добавление нового элемента в конец массива
            arr[arr.Length] = addedComponent;
        }

        public void RemoveByName(string deletedName)
        {
            int indexToRemove = Array.FindIndex(arr, f => f.Name == deletedName);

            // Проверяем, существует ли элемент с заданным именем в массиве
            if (indexToRemove != -1)
            {
                // Создаем новый массив на один элемент меньше и копируем все элементы кроме удаляемого
                ComputerComponent[] newArr = new ComputerComponent[arr.Length - 1];
                Array.Copy(arr, 0, newArr, 0, indexToRemove);
                Array.Copy(arr, indexToRemove + 1, newArr, indexToRemove, arr.Length - indexToRemove - 1);

                // Присваивание нового массива переменной firstArray
                arr = newArr;
            }
        }
    }
}
