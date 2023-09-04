using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _6_hw_2023
{
    public class Magazine
    {
        private string title;
        private int year_of_foundation;
        private string description;
        private string phone;
        private string email;

        public Magazine()
        {
            title= string.Empty;
            year_of_foundation= 0;
            description= string.Empty;
            phone= string.Empty;
            email= string.Empty;
        }

        public Magazine (string title, int year_of_foundation, string description, string phone, string email)
        {
            this.title = title;
            this.year_of_foundation = year_of_foundation;
            this.description = description;
            this.phone = phone;
            this.email = email;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public int YearOfFoundation
        {
            get { return year_of_foundation; }
            set { year_of_foundation = value;}
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
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

            Console.Write("Enter year of foundation: ");
            year_of_foundation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter description: ");
            description = Console.ReadLine();

            Console.Write("Enter phone: ");
            phone = Console.ReadLine();

            Console.Write("Enter email: ");
            email = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Title: {title}\nYear of foundation: {year_of_foundation}\nDescription: {description}\nPhone: {phone}\nEmail: {email}";
        }
    }
}
