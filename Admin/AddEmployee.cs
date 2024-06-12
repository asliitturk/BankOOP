using BankOOP.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_BankOOP_App.Admin
{
    public class AddEmployee : EmployeeInfo
    {
        public AddEmployee(string name, string surname, string address, string emailAddress,
            int age, int password, int employeeId, string position, int wage)
             : base(name, surname, address, emailAddress, age, password, employeeId, position, wage)
        {
        }

        public static void AddEmp(List<EmployeeInfo> employees)
        {
            Console.Write("Enter Your Name :"); // adınızı giriniz
            string name = Console.ReadLine();

            Console.Write("Enter Your Surname :"); // soyadınızı giriniz
            string surname = Console.ReadLine();

            Console.Write("Country / City / District :"); // ülke / şehir / ilçe
            string address = Console.ReadLine();

            Console.Write("Enter Your Email Address :"); //  mail adresinizi giriniz
            string emailAddress = Console.ReadLine();

            Console.Write("Enter Your Date of Birth :"); // dogum tarihi giriniz
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            int age = 2024 - dateOfBirth.Year;

            if (age < 22)
            {
                // 22 yaşından küçük olduğu için kayıt olamadı.
                Console.WriteLine("You must be over 22 to register. Registration failed. You are directed to the exit.");
                return;
            }

            Console.Write("Create Your Password :");
            int password = int.Parse(Console.ReadLine());

            Console.Write("\t\t Select Position : ");
            Console.WriteLine("\t1- Box Office Clerk");
            Console.WriteLine("\t2- Sales Consultant");
            Console.WriteLine("\t3- Customer Representative");
            Console.WriteLine("\t4- Service Representative Specialist");
            Console.WriteLine("\t5- Operations Personnel");
            int positionChoice = int.Parse(Console.ReadLine());
            string position = "";
            int wage = 0;

            switch (positionChoice)
            {
                case 1:
                    position = "Box Office Clerk";
                    wage = 19000;
                    break;
                case 2:
                    position = "Sales Consultant";
                    wage = 23000;
                    break;
                case 3:
                    position = "Customer Representative";
                    wage = 24000;
                    break;
                case 4:
                    position = "Service Representative Specialist";
                    wage = 28000;
                    break;
                case 5:
                    position = "Operations Personnel";
                    wage = 32000;
                    break;
                default:
                    Console.WriteLine("Invalid position choice.");
                    return;
            }

            int employeeId = RandomEmpId();

            AddEmployee newEmployee = new AddEmployee(name, surname, address, emailAddress, age, password, employeeId, position, wage);

            // Yeni çalışanı listeye ekler.
            employees.Add(newEmployee);

            Console.WriteLine("Employee added successfully!");
        }

        private static int RandomEmpId()
        {
            Random rdn = new Random();
            return rdn.Next(2, 501); // 2 ile 500 arasında id uretilir.
        }
    }
}
