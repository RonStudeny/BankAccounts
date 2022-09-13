﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccounts
{
    public class StudentAccount : BaseAccount
    {
        private const decimal withdrawLimit = 1500;

        StudentAccount()
        {
            AccountId = Guid.NewGuid();
        }

        public override void Deposit(decimal ammount)
        {
            if (CheckInput(ammount)) Balance += ammount;
            Console.WriteLine($"Deposit of {ammount} CZK has been made to the account with ID: {AccountId}");
        }

        public override void Withdraw(decimal ammount)
        {
            if (ammount <= Balance && ammount <= withdrawLimit && (CheckInput(ammount)))
            {
                Balance -= ammount;
                Console.WriteLine($"Withdrawal of {ammount} CZK has been made from the account with ID: {AccountId}");
            }
            else throw new BalanceOrLimitReachedException("The provided ammount exceeds the avalible balance or withdrawal limit");
        }

        public override void OnTick()
        {
            throw new NotImplementedException();
        }
    }
}
