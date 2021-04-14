using System;
using System.Globalization;
using Excessoes.Entities.Exceptions;

namespace Excessoes.Entities
{
    class Account
    {
        //Attributes
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        //Constructors
        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        //Methods
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit!");
            }
            if (amount > Balance)
            {
                throw new DomainException("Not enough balance!");
            }
            Balance -= amount;
        }
    }
}