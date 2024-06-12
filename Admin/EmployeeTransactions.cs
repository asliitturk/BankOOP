using BankOOP.Customer;
using BankOOP.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Admin
{
    public class EmployeeTransactions
    {
        public static void EmployeeTransaction(List<EmployeeInfo> employees, List<CustomerInfo> customers)
        {
            Console.WriteLine("Select the sorting method for employees:");
            Console.WriteLine("\t1- Sort by ID");
            Console.WriteLine("\t2- Sort by Position");
            Console.WriteLine("\t3- Sort by Salary (Low to High)");
            Console.WriteLine("\t4- Sort by Address");
            Console.WriteLine("\t5- Sort by Email");
            int sortingChoice = int.Parse(Console.ReadLine());

            switch (sortingChoice)
            {
                case 1:
                    SortEmployeesByID(employees);
                    Thread.Sleep(3000);
                    EmployeeTransaction(employees,customers);
                    break;
                case 2:
                    SortEmployeesByPosition(employees);
                    Thread.Sleep(3000);
                    EmployeeTransaction(employees, customers);
                    break;
                case 3:
                    SortEmployeesByWage(employees);
                    Thread.Sleep(3000);
                    EmployeeTransaction(employees, customers);
                    break;
                case 4:
                    SortEmployeesByAddress(employees);
                    Thread.Sleep(3000);
                    EmployeeTransaction(employees, customers);
                    break;
                case 5:
                    SortEmployeesByEmail(employees);
                    Thread.Sleep(3000);
                    EmployeeTransaction(employees, customers);
                    break;
                default:
                    Console.WriteLine("Invalid transaction!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    AdminScreen.Screen(employees, customers);
                    break;
            }
        }
        public static void SortEmployeesByID(List<EmployeeInfo> employees)
        {
            var sortedEmployees = employees.OrderBy(e => e.EmployeeId).ToList();
            DisplayEmployees(sortedEmployees);
        }

        public static void SortEmployeesByPosition(List<EmployeeInfo> employees)
        {
            var sortedEmployees = employees.OrderBy(e => e.Position).ToList();
            DisplayEmployees(sortedEmployees);
        }

        public static void SortEmployeesByWage(List<EmployeeInfo> employees)
        {
            var sortedEmployees = employees.OrderBy(e => e.Wage).ToList();
            DisplayEmployees(sortedEmployees);
        }

        public static void SortEmployeesByAddress(List<EmployeeInfo> employees)
        {
            var sortedEmployees = employees.OrderBy(e => e.Address).ToList();
            DisplayEmployees(sortedEmployees);
        }

        public static void SortEmployeesByEmail(List<EmployeeInfo> employees)
        {
            var sortedEmployees = employees.OrderBy(e => e.EmailAddress).ToList();
            DisplayEmployees(sortedEmployees);
        }
        public static void DisplayEmployees(List<EmployeeInfo> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.EmployeeId}, Position: {employee.Position}, Salary: {employee.Wage}, Address: {employee.Address}, Email: {employee.EmailAddress}");
            }
        }

    }
}
