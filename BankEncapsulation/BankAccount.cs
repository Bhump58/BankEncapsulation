using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() {}
        private double balance = 0;

        public double Deposit(double value) {
            return balance += value;
        }
        
        public double GetBalance()
        {
            return balance;
        }
    }
}
