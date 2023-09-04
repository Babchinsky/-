using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_hw_09._02._2023
{
    internal class CreditCard
    {
        private string number;
        private string full_name;
        private int cvc;
        private string date_of_expire;
        private int money;

        public CreditCard()
        {
            number = null;
            full_name = null;
            cvc = 0;
            date_of_expire = null;
            money = 0;
        }

        public CreditCard(string number, string full_name, int cvc, string date_of_expire, int money)
        {
            this.number = number;
            this.full_name = full_name;
            this.cvc = cvc;
            this.date_of_expire = date_of_expire;
            this.money = money;
        }

        public string Number { get; set; }
        public string FullName { get; set; }
        public int Cvc { get; set; }
        public string DateOfExpire { get; set; }
        public int Money { get; set; }  

        private void InitNumber()
        {
            Console.Write("Enter a card number: ");
            number = Console.ReadLine();
            try
            {
                if (number == null) throw new ArgumentNullException();
                if (number.Length != 16) throw new Exception("Введено неправильное количество символов");

                foreach (char c in number)
                {
                    if (char.IsDigit(c) == false) throw new Exception("Введены не цифры");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitNumber();
            }
        }
        private void InitName()
        {
            Console.Write("Enter a Full name: ");
            full_name = Console.ReadLine();

            try
            {
                if (full_name == null) throw new ArgumentNullException();
                foreach (char c in number)
                {
                    if (char.IsDigit(c) == true) throw new Exception("Введены цифры");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitName();
            }

        }
        private void InitCVC()
        {
            Console.Write("Enter a CVC: ");

            try
            {
                cvc = Convert.ToInt32(Console.ReadLine());
                if (Math.Floor(Math.Log10(cvc) + 1) != 3) throw new Exception("Введено не 3 числа");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitCVC();
            }

        }
        private void InitDate()
        {
            Console.Write("Enter a date of expire: ");
            date_of_expire = Console.ReadLine();

            try
            {
                if (date_of_expire == null) throw new ArgumentNullException();
                foreach (char c in date_of_expire)
                {
                    if (char.IsDigit(c) == false) throw new Exception("Введены буквы");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitDate();
            }
        }
        private void InitMoney()
        {
            Console.Write("Enter an amount of money: ");

            try
            {
                money = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitCVC();
            }
        }

        public static CreditCard operator +(CreditCard obj, int num)
        {
            obj.money += num;
            return obj;
        }

        public static CreditCard operator -(CreditCard obj, int num)
        {
            obj.money -= num;
            return obj;
        }

        public static bool operator ==(CreditCard obj1, CreditCard obj2)
        {
            if (obj1.cvc == obj2.cvc) return true;
            else return false;
        }

        public static bool operator !=(CreditCard obj1, CreditCard obj2)
        {
            if (obj1.cvc != obj2.cvc) return true;
            else return false;
        }

        public static bool operator >(CreditCard obj1, CreditCard obj2)
        {
            if (obj1.money > obj2.money) return true;
            else return false;
        }

        public static bool operator <(CreditCard obj1, CreditCard obj2)
        {
            if (obj1.money < obj2.money) return true;
            else return false;
        }


        public void Init()
        {
            InitNumber();
            InitName();
            InitCVC();
            InitDate();
            InitMoney();
        }

        public override string ToString()
        {
            return $"Number: {number}\nFull name: {full_name}\nCVC: {cvc}\nDate of Expiry: {date_of_expire}\nAmount of Money: {money}";
        }
    }
}
