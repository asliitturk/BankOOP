using BankOOP.Admin;
using BankOOP.Customer;
using BankOOP.Employee;

namespace BankOOP
{
    class Program
    {
        public static List<CustomerInfo> customers = new List<CustomerInfo>(); // Müşteri koleksiyonu oluşturuldu.
        public static List<AdminInformation> admins = new List<AdminInformation>(); // Admin koleksiyonu oluşturuldu.
        public static List<EmployeeInfo> employees = new List<EmployeeInfo>();
        public Dictionary<string, double> CurrencyBalances { get; set; }
        static void Main(string[] args)
        {
            WelcomeScreen();
            CustomerInfo customer = new CustomerInfo(
                "Aslı",
                "Türk",
                "Türkiye",
                "asliitturk@hotmail.com",
                19,
                10111938,
                50000,
                5000
            );
            customers.Add(customer);
            CustomerMenu.Menu(customer);

            AdminInformation admin = new AdminInformation("Admin", 15987);
            admins.Add(admin);

            EmployeeInfo employee = new EmployeeInfo(
                "Emin",
                "Türk",
                "Germany",
                "emn_trk@hotmail.com",
                33,
                3404,
                1,
                "Service Representative Specialist",
                32000
            );
            employees.Add(employee);
        }

        public static void WelcomeScreen()
        {
            Console.WriteLine("\t\t\t\t\t\t WELCOME ");
            Console.WriteLine("1-\t Login");
            Console.WriteLine("2-\t Signup");
            Console.WriteLine("3-\t Employee Login");
            Console.WriteLine("4-\t Admin Login");
            Console.WriteLine("5-\t Exit");
            Console.WriteLine();
            Console.Write("Select the action you want to take : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You are being directed..");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Login();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("You are being directed..");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Customer.CustomerSignUp.SignUp();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("You are being directed..");
                    Thread.Sleep(2500);
                    Console.Clear();
                    Login();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("You are being directed..");
                    Thread.Sleep(2500);
                    Console.Clear();
                    AdminLogin adminLogin = new AdminLogin();
                    AdminLogin.AdminLog();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Thanks for choosing us.Exiting..");
                    Thread.Sleep(1500);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You made an invalid selection.Try Again.."); // geçersiz işlem. Tekrar Deneyin
                    Thread.Sleep(2000);
                    Console.Clear();
                    WelcomeScreen();
                    break;
            }
        } // KARŞILAMA EKRANI

        public static void Login()
        {
            int loginAttempts = 3; // Başlangıçta 3 giriş hakkı
            bool loggedIn = false;

            while (!loggedIn && loginAttempts > 0)
            {
                Console.WriteLine();
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Enter your password : ");
                int password = int.Parse(Console.ReadLine());

                // Müşteri girişi 
                foreach (var customer in customers)
                {
                    if (customer.Name == name && customer.Password == password)
                    {
                        Console.WriteLine("Login successful.");
                        loggedIn = true;
                        CustomerMenu.Menu(customer);
                        break;
                    }
                }
                // Çalıışan girişi 
                foreach (var employee in employees)
                {
                    if (employee.Name == name && employee.Password == password)
                    {
                        Console.WriteLine($"Login successful. Welcome {employee.Name}");
                        loggedIn = true;
                        // employee menü
                        break;
                    }
                }
                if (!loggedIn) // Giriş başarısız olduysa
                {
                    loginAttempts--; // Kalan giriş hakkını azalt
                    Console.WriteLine($"Invalid username or password. Remaining attempts: {loginAttempts}");
                    Thread.Sleep(2000);
                }
            }
            if (loginAttempts == 0) // Giriş hakkı bitti ise
            {
                Console.WriteLine("Your access rights have expired. Thanks for choosing us..");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
        } // GİRİŞ
    }
}
