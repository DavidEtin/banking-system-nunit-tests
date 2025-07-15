using System;
namespace UTProject.lab2.domain
{
    public interface IRepository
    {
        void Save(Account account);
        void Add(Account account);
        Account FindByUsername(string username);
    }
}
