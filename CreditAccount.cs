using System;
using System.Numerics;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class CreditAccount : BaseAccount
    {
        private const decimal maxDebt = 10_000;
        CreditAccount()
        {
            AccountId = Guid.NewGuid();
        }

        public override void Deposit(decimal ammount)
        {
            if (CheckInput(ammount)) Balance += ammount;
            Console.WriteLine($"Deposit of {ammount} CZK has been made to the credit account with ID: {AccountId}");
            if (Balance > 0)
            {
                Console.WriteLine($"Residue of {Balance} CZK has been detected, money will be sent back promptly");
                Balance = Balance - Balance;            
            }
        }

        public override void Withdraw(decimal ammount)
        {
            decimal temp = 0;
            if (CheckInput(ammount)) temp = ammount + Balance;

            if (temp <= maxDebt)
            {
                Balance -= ammount;
                Console.WriteLine($"Withdrawal of {ammount} CZK has been made from the credit account with ID: {AccountId}");
            }
            else throw new BalanceOrLimitReachedException("The provided ammount exceeds the avalible balance or withdrawal limit");
        }

        public override void OnTick()
        {
            throw new NotImplementedException();
        }
    }
}
