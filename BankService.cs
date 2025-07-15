using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTProject.lab2.domain.Exception;

namespace UTProject.lab2.domain
{
    public class BankService
    {
        private readonly IRepository _repository;

        public BankService(IRepository repository)
        {
            _repository = repository;
        }

        public virtual void ProcessWithdrawal(string username, double amount)
        {
            var account = _repository.FindByUsername(username);
            if (account == null) throw new KeyNotFoundException("Account not found for username: " + username);

            account.Withdraw(amount);
            _repository.Save(account);
        }

        public virtual bool ProcessDeposit(string username, double amount)
        {
            var account = _repository.FindByUsername(username);
            if (account == null) throw new KeyNotFoundException("Account not found for username: " + username);

            account.Deposit(amount);
            _repository.Save(account);
            return true;
        }

        public virtual double CheckBalance(string username)
        {
            var account = _repository.FindByUsername(username);
            if (account == null) throw new KeyNotFoundException("Account not found for username: " + username);
            return account.Balance;
        }
    }
}
