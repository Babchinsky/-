using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_hw_04._04._2023_VisitorPattern
{
    class Program
    {
        static void Main()
        {
            Client client = new Client();
            client.Main();
        }
    }

    class Client
    {
        public void Main()
        {
            var structure = new ObjectStructure();
            structure.Add(new House());
            structure.Add(new Bank());
            structure.Add(new Factory());
            structure.Accept(new BeggineInsuranceAgent());
        }
    }
}
