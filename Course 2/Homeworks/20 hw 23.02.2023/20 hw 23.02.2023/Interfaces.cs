using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPrint
    {
        string Write();
    }

    interface IMoney
    {
        uint Amount { get; set; }
        char cSymbol { get; }
    }

}