using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    public class DepositAccount : Account, IAccount, IWithdraw
    {
        public DepositAccount(double balance, double interestRate, ICustomer customer) : base(balance, interestRate, customer) { }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public double CalculateInterestForPeriod(int months)
        {
            if (this.Balance >= 1000)
            {
                return base.CalculateInterestForPeriod(months);
            }

            return this.Balance;
        }

        public void Withdraw(double amount)
        {
            if (this.Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException("Insufficient money!");
            }

            this.Balance -= amount;
        }
    }
}
