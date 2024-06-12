using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOOP.Customer
{
    public class WithdrawMoney
    {
        public CustomerInfo Customer { get; set; }

        public WithdrawMoney(CustomerInfo customer)
        {
            Customer = customer;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                // Çekilmek istenen miktar 0'dan küçük & eşit olamaz
                Console.WriteLine("The amount to be withdrawn cannot be less than or equal to 0.");
            }
            else if (amount > Customer.Balance)
            {
                // Çekilmek istenen miktar bakiyeden fazla olamaz
                Console.WriteLine("The amount requested to be withdrawn cannot be more than the balance.");
            }
            else
            {
                Customer.Balance -= amount; // Müşterinin bakiyesinden girilen miktar çıkarıldı. Güncel bakiye bildirildi
                Console.WriteLine($"Withdrew {amount}. New Balance: {Customer.Balance}");
            }
        }
    }
}
