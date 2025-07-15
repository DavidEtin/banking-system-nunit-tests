using System;
using UTProject.lab2.domain;

namespace TestUTProject.lab2.tests
{
    public class AccountTest
    {
        private Account account;

        [SetUp]
        public void Setup()
        {
            account = new Account("a1", 100);
        }

    }
}
