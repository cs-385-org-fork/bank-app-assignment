using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
using System.Security.Principal;
using System.Text;

namespace bank_app_assignment
{
    internal class Customer
    {
        private int AccountNumber { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private double Balance { get; set; }

        public double DepositTo(int account, double amount)
        {
            int accountID = account;
            double amountAdded = amount;
            if (accountID == AccountNumber)
            {
                Balance += amountAdded;

            }
            return Balance;
        }
        public double WithdrawFrom(int account, double amount)
        {
            int accountID = account;
            double amountWithdrawn = amount;
            if (accountID == AccountNumber)
            {
                Balance -= amountWithdrawn;
            }
            return Balance;
        }
        public Customer()
        {
            AccountNumber = 0;
            FirstName = "";
            LastName = "";
            Balance = 0.0;
        }
        
    }
}
