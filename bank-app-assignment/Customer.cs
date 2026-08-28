using System;
using System.Collections.Generic;
using System.Drawing.Imaging.Effects;
using System.Security.Principal;
using System.Text;

namespace bank_app_assignment
{
    internal class Customer
    {
        private int _accountNumber;
        private string _firstName;
        private string _lastName;
        private double _balance;
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

       /* public int GetAccountNumber() 
        {
            int account = AccountNumber; 
            return account;
        }
        public void SetAccountNumber(int account)
        {
            AccountNumber = account;
        }
        public string GetFirstName()
        {
            string fName = FirstName;
            return fName;
        }
        public void SetFirstName(string fName)
        {
            FirstName = fName;
        }
        public string GetLastName()
        {
            string lName = FirstName;
            return lName;
        }
        public void SetLastName(string lName)
        {
            LastName = lName;
        }
       */
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
            _accountNumber = 0;
            _firstName = "";
            _lastName = "";
            _balance = 0.0;
        }
        
    }
}
