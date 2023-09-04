using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36b_hw_27._03._2023_FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Main();
        }
    }

    class Client
    {
        public void Main()
        {
            PC pc = new PC(new GPU(), new RAM(), new HDD(), new OpticalDrive(), new PowerUnit(), new Sensors());
            pc.On();

            Console.WriteLine();
            
            pc.Off();
        }
    }
}
