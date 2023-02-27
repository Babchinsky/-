using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_hw_24._02._2023_SOLID_University
{
    abstract class Person
    {
        string full_name;
        string gender;
        string passport;
        string location;

        public Person(string full_name, string gender, string passport, string location)
        {
            this.full_name = full_name;
            this.gender = gender;
            this.passport = passport;
            this.location = location;
        }
        public Person(Person person) :this(person.full_name, person.gender, person.passport, person.location){ }
        public Person() :this("Maksim Ivanov", "Male", "ID123456", "street Deribasovskaya 17"){ }
        public override string ToString()
        {
            return $"\t\tPerson\nFull Name: {full_name}\nGender: {gender}\nPassport: {passport}\nLocation: {location}\n";
        }
    }
}
