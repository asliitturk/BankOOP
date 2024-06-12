using System;
using System.Collections.Generic;
using System.Threading;

namespace BankOOP.Customer
{
    public class AddCurrencyMoney
    {
        private CustomerInfo customer;
        public AddCurrencyMoney(CustomerInfo customer)
        {
            this.customer = customer;
        }


        public static void AddCurrency(CustomerInfo customer)
        {
            Console.Clear();
            Console.WriteLine("1. USD - US Dollar");
            Console.WriteLine("2. EUR - Euro");
            Console.WriteLine("3. GBP - British Pound");
            Console.WriteLine("4. JPY - Japanese Yen");
            Console.WriteLine("5. KRW - South Korean Won");
            Console.Write("Select the currency you want to add : ");
            int choice = int.Parse(Console.ReadLine());

            // Kullanıcıdan eklenecek miktarı iste
            Console.Write("Enter Amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            string currencyName = ""; // Para birimi adı için kullanılıyor

            // Seçilen para birimine göre bakiyeye ekle & para birimi adını ayarla
            switch (choice)
            {
                case 1:
                    currencyName = "USD";
                    break;
                case 2:
                    currencyName = "EUR";
                    break;
                case 3:
                    currencyName = "GBP";
                    break;
                case 4:
                    currencyName = "JPY";
                    break;
                case 5:
                    currencyName = "KRW";
                    break;
                default:
                    Console.WriteLine("You made an invalid transaction, please try again"); // Geçersiz seçim 
                    Thread.Sleep(3000);
                    Console.Clear();
                    AddCurrency(customer);
                    return;
            }

            // Müşterinin para birimini güncelle
            if (!string.IsNullOrEmpty(currencyName))
            {
                // Döviz bakiyesini güncelle
                if (customer.CurrencyBalances.ContainsKey(currencyName))
                {
                    customer.CurrencyBalances[currencyName] += amount;
                }
                else
                {
                    customer.CurrencyBalances.Add(currencyName, amount);
                }

                Console.WriteLine($"{amount} {currencyName} added to your balance");
                foreach (var balance in customer.CurrencyBalances)
                {
                    Console.WriteLine($"* {balance.Value} {balance.Key}");
                }
            }
            ReturnOrMenu.ROrM(customer);
            Thread.Sleep(2000);
        }
    }
}
