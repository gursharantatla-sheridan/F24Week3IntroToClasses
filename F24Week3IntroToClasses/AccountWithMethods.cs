using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24Week3IntroToClasses
{
    public class AccountWithMethods
    {
        // field
        private double _balance;

        // constructor
        public AccountWithMethods(double initialBalance)
        {
            _balance = initialBalance;
        }

        // getters / setters
        public double GetBalance()
        {
            return _balance;
        }

        public void SetBalance(double amount)
        {
            _balance = amount;
        }

        // methods
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
                throw new Exception("Amount cannot exceed the balance");

            _balance -= amount;
        }
    }
}
