using System;

namespace BankOOP.Customer
{
    public class CustomerMenu
    {
        private static string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public static void Menu(CustomerInfo customer)
        {
            Console.WriteLine("\t1-Current Balance Viewing");
            Console.WriteLine("\t2-Add Money");
            Console.WriteLine("\t3-Withdraw Money");
            Console.WriteLine("\t4-Add Currency Money ");
            Console.WriteLine("\t5-Foreign Exchange Transactions");
            Console.WriteLine("\t6-Interest Information Screen");
            Console.WriteLine("\t7-Exit");
            Console.WriteLine();
            Console.WriteLine("Select the action you want to take : ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    var balanceViewer = new CustomerBalance(customer.Balance);
                    balanceViewer.DisplayBalance();
                    break;
                case 2:
                    Console.WriteLine("Enter the amount to add:");
                    decimal addAmount = decimal.Parse(Console.ReadLine());
                    var addMoney = new AddMoney(customer);
                    addMoney.Add(addAmount);
                    break;
                case 3:
                    Console.WriteLine("Enter the amount to withdraw:");
                    decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                    var withdrawMoney = new WithdrawMoney(customer);
                    withdrawMoney.Withdraw(withdrawAmount);
                    break;
                case 4:
                    AddCurrency(customer);
                    break;
                case 5:
                    ForeignExchange.ForeignEx(customer);
                    break;
                case 6:
                    CalculateInterest(customer);
                    break;
                case 7:
                    Console.WriteLine("Thanks for choosing us..Exiting");
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("You made an invalid selection. Try again..");
                    Thread.Sleep(5000);
                    Console.Clear();
                    Menu(customer);
                    break;
            }
        }

        private static void CalculateInterest(CustomerInfo customer)
        {
            Console.WriteLine("Enter the amount to learn about the interest (between 1000 and 90000):");
            double amount = double.Parse(Console.ReadLine());

            if (1000 <= amount && amount <= 90000)
            {
                var interestCalculator = new InterestRateScreen.InterestCalculator();
                double interest = interestCalculator.CalculateInterest(amount);

                var paymentPlanCalculator = new InterestRateScreen.PaymentPlanCalculator();
                ShowPaymentOptions(customer, interest, paymentPlanCalculator);
            }
            else
            {
                Console.WriteLine("Please enter a valid amount between 1000 and 90000.");
            }
        }

        private static void ShowPaymentOptions(CustomerInfo customer, double interest, InterestRateScreen.PaymentPlanCalculator paymentPlanCalculator)
        {
            Console.WriteLine("Select payment plan:");
            Console.WriteLine("\t1-4 Months");
            Console.WriteLine("\t2-8 Months");
            Console.WriteLine("\t3-12 Months");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    paymentPlanCalculator.GeneratePaymentPlan(interest, 4);
                    break;
                case 2:
                    paymentPlanCalculator.GeneratePaymentPlan(interest, 8);
                    break;
                case 3:
                    paymentPlanCalculator.GeneratePaymentPlan(interest, 12);
                    break;
                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }

        private static void AddCurrency(CustomerInfo customer)
        {
            var addCurrencyMoney = new AddCurrencyMoney(customer);
            AddCurrencyMoney.AddCurrency(customer);
        }
    }
}
