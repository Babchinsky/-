using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_hw_09._02._2023_overloading_operations
{
    public class Shop
    {
        private string title;
        private string address;
        private string description;
        private string phone;
        private string email;
        private int square;

        public Shop()
        {
            title = string.Empty;
            address = string.Empty;
            description = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            square = 0;
        }
        public Shop(string title, string address, string description, string phone, string email, int square)
        {
            this.title = title;
            this.address = address;
            this.description = description;
            this.phone = phone;
            this.email = email;
            this.square = square;
        }

        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Square { get; set; }

        public static Shop operator +(Shop obj, int num)
        {
            obj.square += num;
            return obj;
        }

        public static Shop operator -(Shop obj, int num)
        {
            obj.square += num;
            return obj;
        }
        public static bool operator ==(Shop obj1, Shop obj2)
        {
            if (obj1.square == obj2.square) return true;
            else return false;
        }

        public static bool operator !=(Shop obj1, Shop obj2)
        {
            if (obj1.square != obj2.square) return true;
            else return false;
        }

        public static bool operator >(Shop obj1, Shop obj2)
        {
            if (obj1.square > obj2.square) return true;
            else return false;
        }

        public static bool operator <(Shop obj1, Shop obj2)
        {
            if (obj1.square < obj2.square) return true;
            else return false;
        }
        public void Init()
        {
            Console.Write("Enter Title: ");
            title = Console.ReadLine();

            Console.Write("Enter address: ");
            address = Console.ReadLine();

            Console.Write("Enter description: ");
            description = Console.ReadLine();

            Console.Write("Enter phone: ");
            phone = Console.ReadLine();

            Console.Write("Enter email: ");
            email = Console.ReadLine();

            Console.Write("Enter square: ");
            square = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Title: {title}\nAddress: {address}\nDescription: {description}\nPhone: {phone}\nEmail: {email}\nSquare: {square}";
        }
    }
}
