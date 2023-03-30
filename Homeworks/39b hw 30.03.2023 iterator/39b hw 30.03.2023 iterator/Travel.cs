using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39b_hw_30._03._2023_iterator
{
    class Travel : IWalkNumerable
    {
        private Walk[] walks;
        public Travel()
        {
            walks = new Walk[]
            {
                new Walk{Name = "Без гида", Price = 0, Time = 3 },
                new Walk{Name = "Виртуальный гид", Price = 2, Time = 2 },
                new Walk{Name = "Локальный гид", Price = 3, Time = 1 },
            };
        }
        public int Count
        {
            get { return walks.Length; }
        }

        public Walk this[int index]
        {
            get { return walks[index]; }
        }
        public IWalkIterator CreateNumerator()
        {
            return new TravelNumerator(this);
        }
    }
}
