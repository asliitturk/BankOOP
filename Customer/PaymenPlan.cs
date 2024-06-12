using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Customer
{
    public class PaymenPlan
    {
        public abstract class PaymentPlanCalculatorBase
        {
            public abstract void GeneratePaymentPlan(double totalAmount, int months);
        }

        public class PaymentPlanCalculator : PaymentPlanCalculatorBase
        {
            public override void GeneratePaymentPlan(double totalAmount, int months)
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
