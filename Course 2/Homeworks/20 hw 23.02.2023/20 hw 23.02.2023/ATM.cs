using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Interfaces;

namespace nsATM
{
    class ATM
    {
        string mac;
        string firm;

        public string GetCheck(IMoney money, IPrint print)
        {
            return "Method to get check : " + print?.Write() + "\n" +
                "Entered amount of money : " + money?.ToString();

        }
    }
}