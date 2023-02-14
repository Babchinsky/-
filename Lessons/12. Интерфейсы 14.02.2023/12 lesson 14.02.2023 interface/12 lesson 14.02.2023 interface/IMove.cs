using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lesson_14._02._2023_interface
{
    internal interface IMove
    {
        string Name { get; set; }
        void Move();
        void Print();
    }
}
