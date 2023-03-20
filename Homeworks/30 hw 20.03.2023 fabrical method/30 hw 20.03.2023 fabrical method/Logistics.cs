using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_hw_20._03._2023_fabrical_method
{
    class Logistics
    {
        public Logistics() { }
        public void Create(TransportCreator tr)
        {
            tr.Create();
            tr.Deliver();
        }
    }
}
