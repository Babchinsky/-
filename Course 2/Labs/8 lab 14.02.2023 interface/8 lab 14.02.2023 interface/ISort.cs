using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_lab_14._02._2023_interface
{
    internal interface ISort
    {

        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
