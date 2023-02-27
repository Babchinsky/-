using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace nsPrint
{
    class SMS : IPrint
    {
        public string Write()
        {
            return ("Check sended by SMS");
        }
    }

    class Show : IPrint
    {
        public string Write()
        {
            return ("Output on ATM screen");
        }
    }

    class PrintCheck : IPrint
    {
        public string Write()
        {
            return ("Check printed on paper");
        }
    }
}