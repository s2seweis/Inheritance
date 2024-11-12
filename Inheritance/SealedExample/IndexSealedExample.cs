using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.SealedExample
{
    internal class IndexSealedExample
    {
        public IndexSealedExample()
        {
            IndexSealedExampleMethod();
        }

        private void IndexSealedExampleMethod()
        {
            //Manager carl = new Manager("Carl", 45, "Manager", 121452, 10);

            SavingsAccount savingsAccount = new SavingsAccount("1252536", 500.00m);
            savingsAccount.Deposit(200.00m);
            savingsAccount.Withdraw(700.00m);
        }
    }
}
