using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_hw_13._02._2023
{
    internal abstract class Device
    {
        protected string name { get; set; }
        protected string specs { get; set; }

        public Device(){ }
        protected Device(string name, string specs)
        {
            this.name = name;
            this.specs = specs;
        }

        public abstract void Sound();
        public virtual void Show()
        {
            Console.WriteLine($"Name: {name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"Specs: {specs}");
        }
    }
}
