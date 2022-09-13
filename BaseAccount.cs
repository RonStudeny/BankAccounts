using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public abstract class BaseAccount
    {
        public decimal Balance { get; set; }
        public Guid AccountId { get; set; }

        public const decimal interestRate = (decimal)6.2;

        public abstract void Deposit(decimal ammount);

        public abstract void Withdraw(decimal ammount);

        public abstract void OnTick();

        public bool CheckInput(decimal ammount)
        {
            if (ammount <= 0) throw new InvalidAmmountException("Ammount provided is not valid");
            else return true;         
        }

    }
}
