using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_lab_06._02._2023
{
    public class Employee
    {
        private string full_name;
        private string date_of_birth;
        private string phone;
        private string email;
        private string job;
        private string job_description;
        
        public Employee()
        {
            full_name= string.Empty;
            date_of_birth= string.Empty;
            phone= string.Empty;
            email= string.Empty;
            job= string.Empty;
            job_description= string.Empty;
        }
        public Employee(string full_name, string date_of_birth, string phone, string email, string job, string job_description)
        {
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.phone = phone;
            this.email = email;
            this.job = job;
            this.job_description = job_description;
        }

        internal string Full_Name 
        {
            get { return full_name; }
            set { full_name = value; }
        }
        internal string Date_OfBirth
        {
            get { return date_of_birth; }
            set { date_of_birth = value; }
        }
        internal string Phone
        {
            get { return phone; }
            set { phone = value; } 
        }
        internal string Email
        {
            get { return email; }
            set { email = value; }
        }
        internal string Job
        {
            get { return job; } 
            set { job = value; }
        }
        internal string JobDescription
        {
            get { return job_description; }
            set { job_description = value; }
        }

        public override string ToString()
        {
            return $"Full name: {full_name}\nDate of birth: {date_of_birth}\nPhone: {phone}\nEmail: {email}\nJob: {job}\nJob description: {job_description}";
        }
    }
}
