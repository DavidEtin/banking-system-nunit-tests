using System;

namespace UTProject.lab2.domain.Exception
{
    public class AccountNotFoundException : System.Exception
    {
        public AccountNotFoundException(string message) : base(message)
        {
        }

        public AccountNotFoundException(string message, System.Exception cause) : base(message, cause)
        {
        }
    }
}
