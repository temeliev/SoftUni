using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    public class LoanAccount : Account, IAccount
    {
        public LoanAccount(double balance, double interestRate, ICustomer customer) : base(balance, interestRate, customer) { }

        public double CalculateInterestForPeriod(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months - 3 > 0)
                {
                    return base.CalculateInterestForPeriod(months - 3);
                }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months - 2 > 0)
                {
                    return base.CalculateInterestForPeriod(months - 2);
                }
            }

            return this.Balance;
        }
    }
}
