using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
	class Bankomat
	{
		decimal money;

		public Bankomat(decimal money)
		{ 
			this.money = money;
		}

		public Bankomat() :this(0){ }

		public void Put(decimal money, Check check)
		{
			this.money += money;
			check.Put(money);
		}
        public void Withdraw(decimal money, Check check)
        {
            this.money -= money;
            check.Withdraw(money);
        }

		public void Info()
		{
			Console.WriteLine("Баланс: " + money + " грн");
		}
    }
}
