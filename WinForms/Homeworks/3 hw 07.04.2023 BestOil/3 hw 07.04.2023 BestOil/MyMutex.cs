using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _3_hw_07._04._2023_BestOil
{
    public class MyMutex
    {
        private bool locked = false;

        public void Acquire()
        {
            lock (this)
            {
                while (locked)
                {
                    Monitor.Wait(this);
                }
                locked = true;
            }
        }

        public void Release()
        {
            lock (this)
            {
                locked = false;
                Monitor.Pulse(this);
            }
        }
    }
}
