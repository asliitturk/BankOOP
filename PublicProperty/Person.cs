using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.PublicProperty
{
    public class Person
    {
        public Person(string name, string surname, string address, string emailAddress, int age, int password)
        {
            Name = name;
            Surname = surname;
            Address = address;
            EmailAddress = emailAddress;
            Age = age;
            Password = password;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public int Password { get; set; }

    }
}
