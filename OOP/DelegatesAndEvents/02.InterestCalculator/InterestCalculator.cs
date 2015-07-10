namespace _02.InterestCalculator
{
    public class InterestCalculator
    {
        public InterestCalculator(int sum, decimal interest, int years, CalculateInterest calcInterestDelegate)
        {
            this.InterestAmount = calcInterestDelegate(sum, interest, years);
        }

        public decimal InterestAmount { get; set; }
    }
}
