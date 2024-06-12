using BankOOP.Customer;
using BankOOP.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Admin
{
    public class AdminScreen
    {
        public static void Screen(List<EmployeeInfo> employees, List<CustomerInfo> customers)
        {
            Console.WriteLine("\t\t\t\t\t\t WELCOME ");
            Console.WriteLine("\t\t\t\tHello Admin!");
            Console.WriteLine("\t1-Customer Transactions");
            Console.WriteLine("\t2-Employee Transactions");
            Console.WriteLine("\t3-Return Or Menu");
            Console.WriteLine("Select the action you want to take");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You are being directed.."); // yönlendiriliyor
                    Thread.Sleep(3500);
                    Console.Clear();
                    CustomerTransactions.CustomerTransaction(customers, employees);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You are being directed..");
                    Thread.Sleep(3500);
                    Console.Clear();
                    CustomerTransactions.CustomerTransaction(customers, employees);
                    break;
                case 3:
                    ReturnOrMenu.ROrM(employees, customers);
                    break; 
                default:
                    Console.WriteLine("You made an invalid selection. Try again..");
                    Thread.Sleep(4000);
                    Console.Clear();
                    Screen(employees, customers);
                    break;
            }

        }
    }
}
