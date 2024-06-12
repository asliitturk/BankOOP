using BankOOP.Customer;
using BankOOP.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Admin
{
    public class AdminLogin
    {
        // Program sınıfındaki admins listesine erişmek için static olarak tanımlanması gerekiyor
        public static List<AdminInformation> admins = new List<AdminInformation>();
        public static List<EmployeeInfo> employees = new List<EmployeeInfo>();
        public static List<CustomerInfo> customers = new List<CustomerInfo>();
        public static void AdminLog() // Erişim belirleyicisi public olarak güncellendi
        {
            Console.WriteLine();
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter your password : ");
            int password = int.Parse(Console.ReadLine());

            foreach (var admin in admins)
            {
                if (admin.Name == name && admin.Password == password)
                {
                    Console.WriteLine("Login successful.");
                    // Admin menüsüne yönlendiriliyor
                    Console.Clear();
                    AdminScreen.Screen(employees, customers);
                    break;
                }
            }
        }
    }
}
