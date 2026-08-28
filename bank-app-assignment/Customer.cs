using System;
using System.Collections.Generic;
using System.Text;

namespace bank_app_assignment
{
    internal class Customer
    {
        private int accountNumber { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private double initialBalance { get; set; }

        public Customer()
        {
            accountNumber = 0;
            firstName = "";
            lastName = "";
            initialBalance = 0.0;
        }
    }
}
