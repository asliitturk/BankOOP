using BankOOP.Customer;
using BankOOP.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Admin
{
    public class CustomerTransactions
    {
        public static void CustomerTransaction(List<CustomerInfo> customers, List<EmployeeInfo> employees)
        {
            Console.WriteLine("Select the sorting method for customers:");
            Console.WriteLine("\t1- Sort by Name (A-Z)");
            Console.WriteLine("\t2- Sort by Balance (Low - High)");
            Console.WriteLine("\t3- Sort by Address");
            Console.WriteLine("\t4- Sort by Email");
            int sortingChoice = int.Parse(Console.ReadLine());

            switch (sortingChoice)
            {
                case 1:
                    SortCustomersByName(customers);
                    Thread.Sleep(3000);
                    CustomerTransaction(customers,employees);
                    break;
                case 2:
                    SortCustomersByBalance(customers);
                    Thread.Sleep(3000);
                    CustomerTransaction(customers, employees);
                    break;
                case 3:
                    SortCustomersByAddress(customers);
                    Thread.Sleep(3000);
                    CustomerTransaction(customers, employees);
                    break;
                case 4:
                    SortCustomersByEmail(customers);
                    Thread.Sleep(3000);
                    CustomerTransaction(customers, employees);
                    break;
                default:
                    Console.WriteLine("Invalid sorting choice. Returning to main menu.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    AdminScreen.Screen(employees, customers);
                    break;
            }
        }
        public static void SortCustomersByName(List<CustomerInfo> customers)
        {
            var sortedCustomers = customers.OrderBy(c => c.Name).ToList();
            DisplayCustomers(sortedCustomers);
        }

        public static void SortCustomersByBalance(List<CustomerInfo> customers)
        {
            var sortedCustomers = customers.OrderBy(c => c.Balance).ToList();
            DisplayCustomers(sortedCustomers);
        }

        public static void SortCustomersByAddress(List<CustomerInfo> customers)
        {
            var sortedCustomers = customers.OrderBy(c => c.Address).ToList();
            DisplayCustomers(sortedCustomers);
        }

        public static void SortCustomersByEmail(List<CustomerInfo> customers)
        {
            var sortedCustomers = customers.OrderBy(c => c.EmailAddress).ToList();
            DisplayCustomers(sortedCustomers);
        }
        public static void DisplayCustomers(List<CustomerInfo> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Name: {customer.Name}, Balance: {customer.Balance}, Address: {customer.Address}, Email: {customer.EmailAddress}");
            }
        }
    }
}
