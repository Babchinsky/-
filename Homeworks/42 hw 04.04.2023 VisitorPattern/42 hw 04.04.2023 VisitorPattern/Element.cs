using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42_hw_04._04._2023_VisitorPattern
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
        //public string SomeState { get; set; }
    }

    class House : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.House(this);
        }
        public void OperationA()
        {
            Console.WriteLine("Пришёл в дом и предложил медицинскую страховку");
        }
    }

    class Bank : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitBank(this);
        }
        public void OperationB()
        {
            Console.WriteLine("Пришёл в банк и предложил страховку от грабежа");
        }
    }

    class Factory : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitFactory(this);
        }
        public void OperationC()
        {
            Console.WriteLine("Пришёл на фабрику и предложил страховку от пожара и наводнения");
        }
    }
}
