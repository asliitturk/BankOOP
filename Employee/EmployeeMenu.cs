using System;
using System.Collections.Generic;
using System.Threading;
using BankOOP.Customer;
using BankOOP.Employee;

namespace BankOOP.Employee
{
    public class EmployeeMenu
    {
        public static void Menu(EmployeeInfo employee)
        {
            Console.WriteLine("\t1-Full List of Customers");
            Console.WriteLine("\t2-Change Password");
            Console.WriteLine("\t3-See My Information");
            Console.WriteLine("\t4-Return or Menu");
            Console.WriteLine();
            Console.WriteLine("Select the action you want to take:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowFullCustomerList(employee);
                    break;
                case 2:
                    ChangePassword(employee);
                    break;
                case 3:
                    ShowMyInformation(employee);
                    break;
                case 4:
                    ReturnOrMenu.ROrM(employee);
                    break;
                default:
                    Console.WriteLine("You made an invalid selection. Try again.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Menu(employee);
                    break;
            }
        }
        private static void ShowFullCustomerList(EmployeeInfo employee)
        {
            Console.WriteLine("Full List of Customers :");
            foreach (var customer in Program.customers)
            {
                Console.WriteLine($"Name: {customer.Name}, Surname: {customer.Surname}, Balance: {customer.Balance}");
            }
            ReturnOrMenu.ROrM(employee);
        }
        private static void ChangePassword(EmployeeInfo employee)
        {
            Console.WriteLine("Enter your new password :");
            int newPassword = int.Parse(Console.ReadLine());
            employee.Password = newPassword;
            Console.WriteLine("Password changed successfully.");
            Thread.Sleep(2000);
            ReturnOrMenu.ROrM(employee);
        }
        private static void ShowMyInformation(EmployeeInfo employee)
        {
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Surname: {employee.Surname}");
            Console.WriteLine($"Address: {employee.Address}");
            Console.WriteLine($"Email Address: {employee.EmailAddress}");
            Console.WriteLine($"Age: {employee.Age}");
            Console.WriteLine($"Employee ID: {employee.EmployeeId}");
            Console.WriteLine($"Position: {employee.Position}");
            Console.WriteLine($"Wage: {employee.Wage}");
            ReturnOrMenu.ROrM(employee);
        }
    }
}
