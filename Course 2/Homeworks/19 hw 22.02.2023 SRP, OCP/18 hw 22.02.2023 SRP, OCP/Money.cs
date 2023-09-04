using System;


namespace Bankomat
{ 
    interface ICurrency
    {

    }
    internal abstract class Currency
    {
        public decimal amount;
        public Currency(decimal amount) => this.amount = amount; 
        public Currency() :this(0){ }
    }

    class UAH : Currency 
    {
        public UAH(decimal amount)
        {
            this.amount = amount;
        }
    }
    class USD : Currency
    {
        public USD(decimal amount)
        {
            this.amount = amount;
        }
    }
    class EUR : Currency
    {
        public EUR(decimal amount)
        {
            this.amount = amount;
        }
    }



    
}
