using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Customer
{
    public class InterestRateScreen
    {
        public abstract class InterestCalculatorBase
        {
            public abstract double CalculateInterest(double amount);
        }

        public class InterestCalculator : InterestCalculatorBase
        {
            public override double CalculateInterest(double amount)
            {
                if (1000 <= amount && amount <= 5000)
                {
                    return CalculateInterest(amount, 0.05);
                }
                else if (5000 < amount && amount <= 10000)
                {
                    return CalculateInterest(amount, 0.10);
                }
                else if (10000 < amount && amount <= 30000)
                {
                    return CalculateInterest(amount, 0.30);
                }
                else if (30000 < amount && amount <= 50000)
                {
                    return CalculateInterest(amount, 0.50);
                }
                else if (50000 < amount && amount <= 70000)
                {
                    return CalculateInterest(amount, 0.70);
                }
                else if (70000 < amount && amount <= 90000)
                {
                    return CalculateInterest(amount, 0.90);
                }
                else
                {
                    Console.WriteLine("Invalid amount entered."); // geçersiz miktar girildi
                    return CalculateInterest(amount);
                }
            }

            private double CalculateInterest(double amount, double interestRate)
            {
                return amount * (interestRate / 100);
            }
        }
        public class PaymentPlanCalculator
        {
            public void GeneratePaymentPlan(double totalAmount, int months)
            {
                double monthlyPayment = totalAmount / months;
                for (int i = 1; i <= months; i++)
                {
                    Console.WriteLine($" Month {i}: {monthlyPayment}");
                }
            }
        }
    }
}
