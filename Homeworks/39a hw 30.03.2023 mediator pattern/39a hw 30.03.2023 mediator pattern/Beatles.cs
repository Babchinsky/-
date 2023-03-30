using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _39a_hw_30._03._2023_mediator_pattern
{
    class Beatles : Participant
    {
        //public Beatles(string name) : Participant(name) { }
        //   public override void Receive(string from, string message);
        public Beatles(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a Beatles: ");
            base.Receive(from, message);
        }
    }
}
