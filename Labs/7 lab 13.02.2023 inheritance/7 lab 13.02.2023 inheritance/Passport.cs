using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_lab_13._02._2023_inheritance
{
    internal class Passport
    {
        private string Full_name { get; set; }
        private DateTime Date_of_birth { get; set; }
        private DateTime Date_of_expiry { get; set; }
        private string No { get; set; }

        public Passport() :this("Ivan Maksimov", new DateTime(2003, 07, 11), new DateTime(2025,09,21), "1234123409") { }
        public Passport(string full_name, DateTime date_of_expiry, DateTime date_of_birth, string no)
        {
            Full_name = full_name;
            Date_of_birth = date_of_birth;
            Date_of_expiry = date_of_expiry;
            No = no;
        }

        public virtual void Print()
        {
            Console.Write($"Full name: {Full_name}\nDate of birth: {Date_of_birth}\nDate of expiry: {Date_of_expiry}\nNo.: {No}\n");
        }

        public override string ToString()
        {
            return $"Full name: {Full_name}\nDate of birth: {Date_of_birth}\nDate of expiry: {Date_of_expiry}\nNo.: {No}\n";
        }
    }
}
