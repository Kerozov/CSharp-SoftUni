using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    class BankAccount
    {
        public BankAccount(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; set; }
    }
}
