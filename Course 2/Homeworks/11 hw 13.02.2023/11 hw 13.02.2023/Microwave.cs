﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_hw_13._02._2023
{
    internal class Microwave : Device
    {
        public Microwave() : base() { }
        public Microwave(string name, string specs) : base(name, specs) { }

        public override void Sound()
        {
            Console.WriteLine("Бзз");
        }
        public override void Show()
        {
            base.Show();
        }
        public override void Desc()
        {
            base.Desc();
        }
    }
}
