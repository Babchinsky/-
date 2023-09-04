using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _39a_hw_30._03._2023_mediator_pattern
{
    //ConcreteColleague class
    class NonBeatles : Participant
    {

        public NonBeatles(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.WriteLine("To a non-Beatles: ");
            base.Receive(from, message);
        }
    };
}
