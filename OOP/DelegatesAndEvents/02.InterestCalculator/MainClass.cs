namespace _02.InterestCalculator
{
    using System;

    public delegate decimal CalculateInterest(decimal sumOfMoney, decimal interest, int years);

    public class MainClass
    {
        static void Main()
        {
            CalculateInterest calcInterestDelegate = GetSimpleInterest;
            var interestCalculator = new InterestCalculator(2500, 0.072M, 15, calcInterestDelegate);
            Console.WriteLine("{0:F4}", interestCalculator.InterestAmount);
            calcInterestDelegate += GetCompoundInterest;
            interestCalculator = new InterestCalculator(500, 0.056M, 10, calcInterestDelegate);
            Console.WriteLine("{0:F4}", interestCalculator.InterestAmount);
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + interest * years);
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            decimal baseValue = (1 + interest / 12);
            var result = Math.Pow((double)baseValue, years * 12);
            return (decimal)result * sum;
        }
    }
}
