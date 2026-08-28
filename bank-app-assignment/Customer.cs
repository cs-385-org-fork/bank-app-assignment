using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
using System.Security.Principal;
using System.Text;

namespace bank_app_assignment
{
    internal class Customer
    {
        private int accountNumber { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private double balance { get; set; }

        public double depositTo(int account, double amount)
        {
            int accountID = account;
            double amountAdded = amount;
            if (accountID == accountNumber)
            {
                balance += amountAdded;

            }
            return balance;
        }
        public double withdrawFrom(int account, double amount)
        {
            int accountID = account;
            double amountWithdrawn = amount;
            if (accountID == accountNumber)
            {
                balance -= amountWithdrawn;
            }
            return balance;
        }
        public Customer()
        {
            accountNumber = 0;
            firstName = "";
            lastName = "";
            balance = 0.0;
        }
        
    }
}
