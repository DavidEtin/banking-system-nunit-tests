using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTProject.lab2.domain.Exception;

namespace UTProject.lab2.domain
{

    public class Account
    {
        public double Balance { get; private set; }
        public string Id { get; private set; }

        public Account(string id, double initialBalance)
        {
            Balance = initialBalance;
            Id = id;
        }

        public virtual void SetBalance(double balance)
        {
            Balance = balance;
        }

        public virtual void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit amount must be greater than zero");
            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Withdrawal amount must be greater than zero");
            if (amount > Balance) throw new InvalidOperationException("Insufficient funds for withdrawal");
            Balance -= amount;
        }

   
    }

}
