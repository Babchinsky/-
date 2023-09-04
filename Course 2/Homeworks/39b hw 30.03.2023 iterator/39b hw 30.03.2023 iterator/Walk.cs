using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39b_hw_30._03._2023_iterator
{
    interface IWalkIterator
    {
        bool HasNext();
        Walk Next();
    }
    interface IWalkNumerable
    {
        IWalkIterator CreateNumerator();
        int Count { get; }
        Walk this[int index] { get; }
    }
    class Walk
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Time { get; set; }
    }
}
