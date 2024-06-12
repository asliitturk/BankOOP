using System;
using System.Threading;
using BankOOP.Admin;
using BankOOP.Customer;
using BankOOP.Employee;

namespace BankOOP.Admin
{
    public static class ReturnOrMenu
    {
        public static void ROrM(List<EmployeeInfo> employees, List<CustomerInfo> customers)
        {
            Console.WriteLine("Press 'W' to return to the welcome screen, 'C' to return to the Admin Menu, or 'E' to exit.");
            char choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'W':
                    Console.WriteLine("You are being redirected");
                    Thread.Sleep(3000);
                    Program.WelcomeScreen();
                    break;
                case 'C':
                    Console.WriteLine("You are being redirected");
                    Thread.Sleep(3000);
                    AdminScreen.Screen(employees, customers);
                    break;
                case 'E':
                    Console.WriteLine("Thank you for choosing us. Exiting..");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    Thread.Sleep(2000);
                    ReturnOrMenu.ROrM(employees, customers);
                    break;
            }
        }
    }
}
