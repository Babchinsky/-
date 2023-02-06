using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_hw_2023
{
    public class Website
    {
        private string title;
        private string url;
        private string description;
        private string ip;

        public Website() 
        {
            title= string.Empty;
            url= string.Empty;
            description= string.Empty;
            ip= string.Empty;
        }
        public Website(string title, string url, string description, string ip)
        {
            this.title = title;
            this.url = url;
            this.description = description;
            this.ip = ip;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }

        public void Init()
        {
            Console.Write("Enter Title: ");
            title = Console.ReadLine();

            Console.Write("Enter URL: ");
            url = Console.ReadLine();

            Console.Write("Enter description: ");
            description = Console.ReadLine();

            Console.Write("Enter IP: ");
            ip = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Title: {title}\nURL: {url}\nDescription: {description}\nIP: {ip}";
        }
    }
}
