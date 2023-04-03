using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41a_hw_04._03._2023_StatePattern
{
    // The 'Context' class
    class Account
    {
        State state;
        string owner;

        public Account(string owner)
        {
            this.owner = owner;
        }
        public double GetBalance()
        {
            return state.GetBalance();
        }
        public State GetState()
        {
            return state;
        }
        public void SetState(State state)
        {
            this.state = state;
        }
        public void Deposit(double amount)
        {
            state.Deposit(amount);
            string buffer = string.Empty;
            buffer = string.Format($"Deposited ---- {amount}");
            Console.WriteLine(buffer);
            buffer = string.Format($"Balance {this.GetBalance()}");
            Console.WriteLine(buffer);
            buffer = string.Format($"Status {this.GetState().GetType().Name}");
            Console.WriteLine(buffer);
            Console.WriteLine();
        }
        public void Withdraw(double amount)
        {
            if (state.Withdraw(amount))
            {
                string buffer = string.Empty;
                buffer = string.Format($"Withdraw ---- {amount}");
                Console.WriteLine(buffer);
                buffer = string.Format($"Balance {this.GetBalance()}");
                Console.WriteLine(buffer);
                buffer = string.Format($"Status {this.GetState().GetType().Name}");
                Console.WriteLine(buffer);
                Console.WriteLine();
            }
        }
        public void PayInterest()
        {
            if (state.PayInterest())
            {
                string buffer = string.Empty;
                buffer = string.Format($"Interest Paid ----");
                Console.WriteLine(buffer);
                buffer = string.Format($"Balance {this.GetBalance()}");
                Console.WriteLine(buffer);
                buffer = string.Format($"Status {this.GetState().GetType().Name}");
                Console.WriteLine(buffer);
                Console.WriteLine();
            }
        }
    }
}
