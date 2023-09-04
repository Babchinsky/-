using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _42_hw_04._04._2023_VisitorPattern
{
    abstract class Visitor
    {
        public abstract void House(House house);
        public abstract void VisitBank(Bank bank);
        public abstract void VisitFactory(Factory factory);
    }

    class BeggineInsuranceAgent : Visitor
    {
        public override void House(House house)
        {
            house.OperationA();
        }
        public override void VisitBank(Bank bank)
        {
            bank.OperationB();
        }

        public override void VisitFactory(Factory factory)
        {
            factory.OperationC();
        }
    }
}
