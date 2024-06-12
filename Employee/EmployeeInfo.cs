using BankOOP.Customer;
using BankOOP.PublicProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Employee
{
    public class EmployeeInfo : Person
    {
        public int EmployeeId { get; set; }
        public string Position { get; set; }
        public int Wage { get; set; }
        public EmployeeInfo(string name, string surname, string address,
             string emailAddress, int age, int password, int employeeId, string position, int wage)
             : base(name, surname, address, emailAddress, age, password)
        {
            EmployeeId = employeeId;
            Position = position;
            Wage = wage;
        }
    }
}
