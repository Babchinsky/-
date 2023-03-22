using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _32_hw_22._03._2023_CarBuilder
{
    public class Client
    {
        public void Main()
        {
            Builder daewooLanosBuilder = new DaewooLanosBuilder();
            Shop director = new Shop(daewooLanosBuilder);
            director.Construct();
            Car daewooLanos1 = daewooLanosBuilder.getResult();
            Console.WriteLine(daewooLanos1);

            Console.WriteLine();

            Builder hyundaiGetzBuilder = new HyundaiGetzBuilder();
            director = new Shop(hyundaiGetzBuilder);
            director.Construct();
            Car hyundaiGetz1 = hyundaiGetzBuilder.getResult();
            Console.WriteLine(hyundaiGetz1);
        }
    }
}
