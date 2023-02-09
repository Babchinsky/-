using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_hw_09._02._2023
{
    public class Employee
    {
        private string full_name;
        private string date_of_birth;
        private string phone;
        private string email;
        private string job;
        private string job_description;
        private int salary;

        public Employee()
        {
            full_name = string.Empty;
            date_of_birth = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            job = string.Empty;
            job_description = string.Empty;
            salary = 0;
        }
        public Employee(string full_name, string date_of_birth, string phone, string email, string job, string job_description, int salary)
        {
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.phone = phone;
            this.email = email;
            this.job = job;
            this.job_description = job_description;
            this.salary = salary;
        }

        public Employee(Employee obj)
        {
            this.full_name = obj.full_name;
            this.date_of_birth = obj.date_of_birth;
            this.phone = obj.phone;
            this.email = obj.email;
            this.job = obj.job;
            this.job_description = obj.job_description;
            this.salary = obj.salary;
        }

        internal string Full_Name { get; set; }

        internal string Date_OfBirth { get; set; }

        internal string Phone { get; set; }

        internal string Email { get; set; }

        internal string Job { get; set; }

        internal string JobDescription { get; set; }

        internal int Salary { get; set; }

        public static Employee operator +(Employee obj, int add)
        {
            obj.salary += add;
            return obj;
        }

        public static Employee operator -(Employee obj, int add)
        {
            obj.salary -= add;
            return obj;
        }

        public static bool operator ==(Employee obj1, Employee obj2)
        {
            if (obj1.salary == obj2.salary) return true;
            else return false;
        }

        public static bool operator !=(Employee obj1, Employee obj2)
        {
            if (obj1.salary!= obj2.salary) return true;
            else return false;
        }

        public static bool operator >(Employee obj1, Employee obj2)
        {
            if (obj1.salary > obj2.salary) return true;
            else return false;
        }

        public static bool operator <(Employee obj1, Employee obj2)
        {
            if (obj1.salary < obj2.salary) return true;
            else return false;
        }

        public override string ToString()
        {
            return $"Full name: {full_name}\nDate of birth: {date_of_birth}\nPhone: {phone}\nEmail: {email}\nJob: {job}\nJob description: {job_description}\nSalary: {salary}";
        }
    }
}
