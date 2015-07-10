using System;
namespace _02.BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main()
        {
            DepositAccount acc = new DepositAccount(222, 2, new CompanyCustomer("test"));
            IAccount acc2 = new DepositAccount(1000, 5, new IndividualCustomer("test2"));
            Console.WriteLine(acc.CalculateInterestForPeriod(12));
            Console.WriteLine(acc2.CalculateInterestForPeriod(12));
            acc.Deposit(22);
            acc.Withdraw(22);
            Console.WriteLine(acc.CalculateInterestForPeriod(12));

            MortgageAccount acc3 = new MortgageAccount(222, 2, new CompanyCustomer("test"));
            acc3.Deposit(18);
            IAccount acc4 = new MortgageAccount(1000, 5, new IndividualCustomer("test2"));
            Console.WriteLine(acc3.CalculateInterestForPeriod(12));
            Console.WriteLine(acc4.CalculateInterestForPeriod(12));

            LoanAccount acc5 = new LoanAccount(222, 2, new CompanyCustomer("test"));
            acc5.Deposit(22);
            IAccount acc6 = new LoanAccount(1000, 5, new IndividualCustomer("test2"));
            Console.WriteLine(acc5.CalculateInterestForPeriod(12));
            Console.WriteLine(acc6.CalculateInterestForPeriod(12));

        }
    }
}
