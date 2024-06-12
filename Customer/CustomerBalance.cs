using System;
using System.Collections.Generic;

namespace BankOOP.Customer
{
    public class CustomerBalance
    {
        public double Balance { get; set; }
        public Dictionary<string, double> CurrencyBalances { get; set; }

        // Constructor
        public CustomerBalance(decimal beginning)
        {
            Balance = (double)beginning;
            CurrencyBalances = new Dictionary<string, double>();
        }
        public CustomerBalance(string name, string surname, string address, string emailAddress,
            int age, int password, decimal balance, decimal currencyBalance)
        {
            Balance = (double)balance;
            CurrencyBalances = new Dictionary<string, double>();
            CurrencyBalances.Add("TRY", (double)currencyBalance); // Müşterinin yerel para birimini (TL) eklendi
        }

        // Müşterinin bakiyesini gösterme metodu
        public void DisplayBalance()
        {
            Console.WriteLine($"Current Balance: {Balance}");
            foreach (var balance in CurrencyBalances)
            {
                Console.WriteLine($"* {balance.Value} {balance.Key}");
            }
        }
    }
}
