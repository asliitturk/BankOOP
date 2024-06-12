using System;
using System.Collections.Generic;
using System.Threading;

namespace BankOOP.Customer
{
    public class CustomerSignUp
    {
        public static List<CustomerInfo> customers = new List<CustomerInfo>();
        public static void SignUp()
        {
            Console.WriteLine("\t\t\t\t\t HELLO !"); // merhaba
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t Welcome To The Registration Screen"); // kayıt ekranına hg
            Console.WriteLine();
            Console.Write("Enter Your Name :"); // adınızı giriniz
            string name = Console.ReadLine();

            Console.Write("Enter Your Surname :"); // soyadınızı giriniz
            string surname = Console.ReadLine();

            Console.Write("Country :"); // ülke / şehir / ilçe
            string address = Console.ReadLine();

            Console.Write("Enter Your Email Address :"); //  mail adresinizi giriniz
            string emailAddress = Console.ReadLine();

            Console.Write("Enter Your Date of Birth :"); // dogum tarihi giriniz
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            int age = 2024 - dateOfBirth.Year;

            if (age < 16)
            {
                // 16 yaşından küçük olduğu için kayıt olamadı.
                Console.WriteLine("You must be over 16 to register.Registration failed. You are directed to the exit.");
                return;
            }
            Console.Write("Create Your Password :");
            int password = int.Parse(Console.ReadLine());

            // Kayıt olan müşterinin adının İLK harfi büyük , diğer harfleri küçük kalıcaktır.
            string settingName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            // Kayıt olan müşterinin soyadının TÜMÜ büyük harf kalıcaktır.
            string settingSurname = char.ToUpper(surname[0]) + surname.Substring(1).ToUpper();
            CustomerInfo customer = new CustomerInfo(settingName, settingSurname, address, emailAddress, age, password, 0, 0);
            customers.Add(customer);

            Console.WriteLine($"Registration successful. {settingName} {settingSurname}");
            Thread.Sleep(3000);
            Console.WriteLine("Returning to the Login Screen..");
            Thread.Sleep(3500);
            Console.Clear();
            Program.Login();
        }// KAYIT
    }
}
