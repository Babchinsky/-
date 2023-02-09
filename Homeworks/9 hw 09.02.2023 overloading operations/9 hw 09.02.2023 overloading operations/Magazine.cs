using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_hw_09._02._2023_overloading_operations
{
    public class Magazine
    {
        private string title;
        private int year_of_foundation;
        private string description;
        private string phone;
        private string email;
        private int employees;

        public Magazine()
        {
            title = string.Empty;
            year_of_foundation = 0;
            description = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            employees = 0;
        }

        public Magazine(string title, int year_of_foundation, string description, string phone, string email, int employees)
        {
            this.title = title;
            this.year_of_foundation = year_of_foundation;
            this.description = description;
            this.phone = phone;
            this.email = email;
            this.employees = employees;
        }

        private string Title { set; get; }
        private int YearOfFoundation { set; get; }
        private string Description { set; get; }
        private string Phone { set; get; }
        private string Email { set; get; }
        private int Employees { set; get; }

        public static Magazine operator +(Magazine obj, int num)
        {
            obj.employees += num;
            return obj;
        }

        public static Magazine operator -(Magazine obj, int num)
        {
            obj.employees -= num;
            return obj;
        }

        public static bool operator ==(Magazine obj1, Magazine obj2)
        {
            if (obj1.employees == obj2.employees) return true;
            else return false;
        }

        public static bool operator !=(Magazine obj1, Magazine obj2)
        {
            if (obj1.employees != obj2.employees) return true;
            else return false;
        }

        public static bool operator >(Magazine obj1, Magazine obj2)
        {
            if (obj1.employees > obj2.employees) return true;
            else return false;
        }

        public static bool operator <(Magazine obj1, Magazine obj2)
        {
            if (obj1.employees < obj2.employees) return true;
            else return false;
        }

        public void Init()
        {
            Console.Write("Enter Title: ");
            title = Console.ReadLine();

            Console.Write("Enter year of foundation: ");
            year_of_foundation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter description: ");
            description = Console.ReadLine();

            Console.Write("Enter phone: ");
            phone = Console.ReadLine();

            Console.Write("Enter email: ");
            email = Console.ReadLine();

            Console.Write("Enter a number of employees: ");
            employees = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Title: {title}\nYear of foundation: {year_of_foundation}\nDescription: {description}\nPhone: {phone}\nEmail: {email}\nNumber of Employees: {employees}";
        }
    }
}
