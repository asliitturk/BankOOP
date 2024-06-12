using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Customer
{
    public static class ReturnOrMenu
    {
        public static void ROrM(CustomerInfo customer)
        {
            Console.WriteLine("Press 'W' to return to the welcome screen, 'C' to return to the customer menu, or 'E' to exit.");
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
                    CustomerMenu.Menu(customer);
                    break;
                case 'E':
                    Console.WriteLine("Thank you for choosing us. Exiting..");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid selection. Try again.");
                    Thread.Sleep(2000);
                    ROrM(customer);
                    break;
            }
        }
    }
}

