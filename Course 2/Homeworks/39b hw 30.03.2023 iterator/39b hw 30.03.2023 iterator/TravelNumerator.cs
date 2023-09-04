using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39b_hw_30._03._2023_iterator
{
    class TravelNumerator : IWalkIterator
    {
        IWalkNumerable aggregate;
        int index = 0;
        public TravelNumerator(IWalkNumerable a)
        {
            aggregate = a;
        }
        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public Walk Next()
        {
            return aggregate[index++];
        }
    }
}
