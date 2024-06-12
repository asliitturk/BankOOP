using System;
using System.Collections.Generic;
using System.Threading;

namespace BankOOP.Customer
{
    public class ForeignExchange
    {
        public static void ForeignEx(CustomerInfo customer)
        {
            Console.Clear();
            Console.WriteLine($"Current Balance: {customer.Balance} ");
            Console.Write("Enter the amount you want to convert: "); // Çevirmek istediğiniz tutarı girin
            double tlAmount = double.Parse(Console.ReadLine());

            if (tlAmount > (double)customer.Balance)
            {
                Console.WriteLine("Insufficient funds!"); // Yetersiz Bakiye 
                Thread.Sleep(2000);
                ReturnOrMenu.ROrM(customer);
                return;
            }
            Console.WriteLine("Currency Screen");
            Console.WriteLine("\t1. USD - US Dollar: 11.25"); // Amerikan Doları
            Console.WriteLine("\t2. EUR - Euro: 12.25"); // Euro
            Console.WriteLine("\t3. GBP - British Pound: 13.50"); // İngiliz Sterlini
            Console.WriteLine("\t4. JPY - Japanese Yen: 10.10"); // Japon Yeni
            Console.WriteLine("\t5. KRW - South Korean Won: 9.50"); // Güney Kore Wonu
            Console.WriteLine();
            Console.Write("Select the currency you want to convert: "); // dönüştüreceği para birimini seçin
            char choice = char.Parse(Console.ReadLine());

            double usd = 11.25, eur = 12.25, gbp = 13.50, jpy = 10.10, krw = 9.50;
            double currencyRate = 0; // Seçilen döviz cinsinin döviz kuru
            string currencyName = ""; // Seçilen döviz cinsinin adı

            switch (choice)
            {
                case '1':
                    currencyRate = usd;
                    currencyName = "USD";
                    break;
                case '2':
                    currencyRate = eur;
                    currencyName = "EUR";
                    break;
                case '3':
                    currencyRate = gbp;
                    currencyName = "GBP";
                    break;
                case '4':
                    currencyRate = jpy;
                    currencyName = "JPY";
                    break;
                case '5':
                    currencyRate = krw;
                    currencyName = "KRW";
                    break;
                default:
                    Console.WriteLine("Invalid transaction."); // Geçersiz seçenek
                    Thread.Sleep(2000);
                    ReturnOrMenu.ROrM(customer);
                    return;
            }
            double convertedAmount = tlAmount / currencyRate;

            // Müşterinin para birimi bakiyesini güncelle
            if (customer.CurrencyBalances.ContainsKey(currencyName))
            {
                customer.CurrencyBalances[currencyName] += convertedAmount;
            }
            else
            {
                customer.CurrencyBalances.Add(currencyName, convertedAmount);
            }

            Console.WriteLine($"{tlAmount} TL converted to {convertedAmount} {currencyName}");

            // Müşterinin güncel TL bakiyesinden dönüştürdüğü tutar eksiltilecek
            customer.Balance -= (decimal)tlAmount;

            Console.WriteLine("Current Currency Balance: ");
            foreach (var balance in customer.CurrencyBalances)
            {
                Console.WriteLine($"* {balance.Value} {balance.Key}");
            }
            Thread.Sleep(2000);
            Console.WriteLine();
            ReturnOrMenu.ROrM(customer);
        }
    }
}
