using System.Collections.Generic;

namespace BankOOP.Customer
{
    public class CustomerInfo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public int Age { get; set; }
        public int Password { get; set; }
        public decimal Balance { get; set; }
        public decimal CurrencyBalance { get; set; }
        public Dictionary<string, double> CurrencyBalances { get; set; }

        public CustomerInfo(string name, string surname, string address, string emailAddress, int age, int password, decimal balance, decimal currencyBalance)
        {
            Name = name;
            Surname = surname;
            Address = address;
            EmailAddress = emailAddress;
            Age = age;
            Password = password;
            Balance = balance;
            CurrencyBalance = currencyBalance;
            CurrencyBalances = new Dictionary<string, double>();
        }
    }
}
