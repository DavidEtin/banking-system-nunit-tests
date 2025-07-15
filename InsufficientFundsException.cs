using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTProject.lab2.domain.Exception
{
    public class InsufficientFundsException : System.Exception
    {
        public InsufficientFundsException() : base("Insufficient funds for withdrawal")
        {
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
}
