using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _38b_hw_29._03._2023_command_pattern
{
    class Controller
    {
        ICommand command;

        public Controller() { }
        public void PresButton()
        { 
            if (command != null)
                command.Execute();
        }
        public void PressUndo() 
        {
            if (command != null)
                command.Undo();
        }
        public void SetCommand(ICommand com) => command = com;
    }

    // Receiver – конечный получатель команды. Именно он располагает информацией о том, как надо обрабатывать команду.
    class TV
    {
        public void Off() => Console.WriteLine("TV is off!");
        public void On() => Console.WriteLine("TV is on!");
    }

    // Receiver – конечный получатель команды. Именно он располагает информацией о том, как надо обрабатывать команду.
    class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Warming up food...");
            Thread.Sleep(time);
        }
        public void StopCooking() => Console.WriteLine("The food is warmed up!");
    }
}
