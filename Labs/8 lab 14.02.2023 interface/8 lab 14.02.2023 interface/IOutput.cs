using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lab_14._02._2023_interface
{
    internal interface IOutput
    {
        int this[int index] { get; set; }
        void Show();
        void Show(string info);
    }
}
