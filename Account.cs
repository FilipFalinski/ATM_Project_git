using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ATM_Project
{
    internal class Account
    {
        private readonly string AccountId;
        private readonly int Pin;
        private Boolean isLogged = false;
        private Decimal Balance;

        public Account(string accountId, int pin, Decimal balance)
        {
            this.AccountId = accountId;
            this.Pin = pin;
            this.Balance = balance;
        }

        public string GetAccountId() => AccountId;

        public Boolean Login(int inputPin)
        {
            if (Pin == inputPin)
            {
                isLogged = true;
            }
            return isLogged;
        }

        public void LogOut()
        {
            isLogged = false;
        }

        public Decimal CheckBalance()
        {
            return Balance;
        }

        public void Deposit(Decimal amount)
        {
            if (!isLogged)
            {
                throw new Exception("Not logged in");
            }
            Balance += amount;
        }

        public Boolean Withdrawl(Decimal amount)
        {
            if (!isLogged)
            {
                throw new Exception("Not logged in");
            }
            if (Balance < amount)
            {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


    }
}
