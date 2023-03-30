using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39b_hw_39._03._2023_IteratorPattern_2._0
{
    class Walk
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Time { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nPrice: {Price}\nTime: {Time}\n";
        }
    }

    // Конкретные Коллекции предоставляют один или несколько методов для
    // получения новых экземпляров итератора, совместимых с классом коллекции.
    class WalksCollection : IteratorAggregate
    {
        //List<string> _collection = new List<string>();
        Walk[] walks;
        bool method;

        public WalksCollection()
        {
            walks = new Walk[]
            {
                new Walk{Name = "Без гида", Price = 0, Time = 3 },
                new Walk{Name = "Виртуальный гид", Price = 2, Time = 2 },
                new Walk{Name = "Локальный гид", Price = 3, Time = 1 }
            };
            method = false;
        }

        public override IEnumerator GetEnumerator()
        {
            return new OrderIterator(this, method);
        }

        public void ReverseDirection()
        {
            method = !method;
        }

        public Walk[] getItems()
        {
            return walks;
        }

        //public void AddItem(string item)
        //{
        //    this._collection.Add(item);
        //}
    }
}
