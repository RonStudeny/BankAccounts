using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    class InvalidAmmountException : Exception
    {
        public InvalidAmmountException(string message) : base(message) { }
    }
}
