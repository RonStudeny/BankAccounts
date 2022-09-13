using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    class BalanceOrLimitReachedException : Exception
    {
        public BalanceOrLimitReachedException(string message) :base(message) { }
    }
}
