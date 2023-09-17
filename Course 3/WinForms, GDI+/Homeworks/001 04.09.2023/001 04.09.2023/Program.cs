using System;
using System.Collections.Generic;
using System.Linq;
using StorageDevicesLibrary;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            HDD hdd = new HDD("Samsung", "A200", "S1", 128, 2, 7200);
            hdd.Print();
        }
    }
}