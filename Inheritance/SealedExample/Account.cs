using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SealedExample
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber=accountNumber;
            Balance=initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}, New balance is {Balance:C}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if(amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount:C}, New balance is {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
