using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    public abstract class Account : IAccount, IDeposit
    {
        private double balance;
        private double interestRate;
        private ICustomer customer;

        protected Account(double balance, double interestRate, ICustomer customer)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Customer = customer;
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The balance is negative!");
                }

                this.balance = value;
            }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative!");
                }

                this.interestRate = value;
            }
        }

        public ICustomer Customer
        {
            get { return this.customer; }
            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer is missing!");
                }

                this.customer = value;
            }
        }

        public double CalculateInterestForPeriod(int months)
        {
            return this.Balance * (1 + ((this.InterestRate * months) / 100));
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
    }
}
