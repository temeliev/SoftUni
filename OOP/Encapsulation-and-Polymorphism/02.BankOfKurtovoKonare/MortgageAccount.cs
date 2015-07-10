using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    public class MortgageAccount : Account, IAccount
    {
        public MortgageAccount(double balance, double interestRate, ICustomer customer) : base(balance, interestRate, customer) { }

        public double CalculateInterestForPeriod(int months)
        {
            if (this.Customer is IndividualCustomer)
            {
                if (months - 6 > 0)
                {
                    return base.CalculateInterestForPeriod(months - 6);
                }
            }
            else if (this.Customer is CompanyCustomer)
            {
                if (months > 0 && months <= 12)
                {
                    return base.CalculateInterestForPeriod(months) / 2;
                }
                
                if (months > 12)
                {
                    return base.CalculateInterestForPeriod(12) / 2 + base.CalculateInterestForPeriod(months - 12);
                }
            }

            return this.Balance;
        }
    }
}
