using System;
using System.Threading;

namespace BankOOP.Customer
{
    public class AddMoney
    {
        public CustomerInfo Customer { get; set; }

        public AddMoney(CustomerInfo customer)
        {
            Customer = customer;
        }

        public void Add(decimal amount)
        {
            Customer.Balance += amount;
            Console.WriteLine($"Added {amount}. New Balance: {Customer.Balance}");
        }
    }
}
