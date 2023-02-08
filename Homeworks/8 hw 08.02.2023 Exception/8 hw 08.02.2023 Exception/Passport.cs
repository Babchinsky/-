using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_hw_08._02._2023_Exception
{
    internal class Passport
    {
        private string no;
        private string full_name;
        private DateTime date_of_expiry;

        public Passport()
        {
            no = null;
            full_name= null;
            date_of_expiry= DateTime.MinValue;
        }

        public Passport(string no, string full_name, DateTime date_of_expiry)
        {
            this.no = no;
            this.full_name = full_name;
            this.date_of_expiry = date_of_expiry;
        }

        private string No { get; set; }
        private string FullName { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public void InitNo()
        {
            Console.Write("Enter No.(in example, AB123456): ");

            try
            {
                no = Console.ReadLine();
                if (no.Length != 8) throw new Exception("Символов не 8");

                if (char.IsLetter(no[0]) == false && char.IsLetter(no[1]) == false) throw new Exception("Неправильный формат ввода");
                for (int i = 2; i < no.Length; i++) 
                {
                    if (char.IsDigit(no[i]) == false) throw new Exception("Неправильный формат ввода");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Message: " + ex.Message);
                InitNo();
            }
            
        }

        public void InitFullName()
        {
            Console.Write("Enter Full Name: ");

            try
            {
                full_name = Console.ReadLine();
                foreach (char ch in full_name)
                {
                    if (ch == ' ') continue;
                    else if (char.IsNumber(ch)) throw new Exception("Нельзя вводить цифры");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitFullName();
            }
        }

        public void InitDateOfExpiry()
        {
            Console.Write("Enter Date of Expiry: ");

            try
            {
                date_of_expiry = Convert.ToDateTime(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                InitDateOfExpiry();
            }
        }



        public void Init()
        {
            InitNo();
            InitFullName();
            InitDateOfExpiry();
        }

        public override string ToString()
        {
            return $"No.: {no}\nFull Name: {full_name}\nDate of Expiry: {date_of_expiry.Day}.{date_of_expiry.Month}.{date_of_expiry.Year}";
        }
    }
}
