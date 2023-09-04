using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38b_hw_29._03._2023_command_pattern
{
    // ICommand – интерфейс, представляющий команду.
    abstract class ICommand
    {
	    public abstract void Execute();
	    public abstract void Undo();
    }

    // TVOnCommand – конкретная команда.
    class TVOnCommand : ICommand
    {
        TV tv;
        public TVOnCommand(TV tvSet) => tv = tvSet;

        public override void Execute()
        {
            tv.On();
        }

        public override void Undo()
        {
            tv.Off();
        }
    }

    // MicrowaveCommand – конкретная команда.
    class MicrovaweCommand : ICommand
    {
        Microwave microwave;
        int time;

        public MicrovaweCommand(Microwave m, int t)
        {
            microwave = m;
            time = t;
        }
        public override void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }

        public override void Undo()
        {
            microwave.StopCooking();    
        }
    }
}
