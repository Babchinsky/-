using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_lab_07._03._2023_Ex2
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Human() { }

        public Human(string Name, string Surname, string Email, string Phone)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Email = Email;
            this.Phone = Phone;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Email} {Phone}";
        }

        public string Output()
        {
            return $"Имя: {Name}\nФамилия: {Surname}\nEmail: {Email}\nТелефон: {Phone}\n";
        }
    }
}
