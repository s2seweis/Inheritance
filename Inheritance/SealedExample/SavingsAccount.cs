using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SealedExample
{
    public sealed class SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance)
        {

        }

        public override void Withdraw(decimal amount)
        {
           if (amount <= Balance)
            {
                base.Withdraw(amount);
            }
            else
            {
                {
                    Console.WriteLine("Insufficient funds. canot withdraw from a savings account.");
                }
            }
        }
    }
}

// Design integrity:
// Sealing a class ensures that ist designs is final and cannot be altered through inheritance. 
// This is crucial when you want to enforce specific behaviour and prevent modifications that could compromise the design. 

// Example: In the banking application, the SavingsAccount class has specific withdrawl rules;
// that should not be overridden by any further derived class. 

//SecurityAction:
// Preventing further inheritance can enhance security by avoiding unintended behaviour or misuse. 
// By sealing a class, you ensure that critical functionally remains consistent and secure.  

// Example:
// By dealing the SavingsAccount class, you ensure that no unauthorized or accidental changes can be made;
// to how withdrawls are processed, maintaining the security of the account operations