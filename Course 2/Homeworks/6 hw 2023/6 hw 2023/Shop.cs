using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _6_hw_2023
{
    public class Shop
    {
        private string title;
        private string address;
        private string description;
        private string phone;
        private string email;

        public Shop()
        {
            title = string.Empty;
            address = string.Empty;
            description = string.Empty;
            phone = string.Empty;
            email = string.Empty;
        }
        public Shop(string title, string address, string description, string phone, string email)
        {
            this.title = title;
            this.address = address;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Description
        {
            get { return description; }
            set { description= value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
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
        }

        public override string ToString()
        {
            return $"Title: {title}\nAddress: {address}\nDescription: {description}\nPhone: {phone}\nEmail: {email}";
        }
    }
}
