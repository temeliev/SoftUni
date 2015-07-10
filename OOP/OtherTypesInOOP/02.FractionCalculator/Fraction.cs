using System;

namespace _02.FractionCalculator
{
    public struct Fraction
    {
        private long denominator;
        private decimal result;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.result = (decimal)this.Numerator / this.Denominator;
        }

        public long Numerator { get; set; }

        public long Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be 0!");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction numerator1, Fraction numerator2)
        {
            long num = (numerator1.Numerator * numerator2.Denominator) + (numerator2.Numerator * numerator1.Denominator);
            long dnum = numerator1.Denominator * numerator2.Denominator;
            return new Fraction(num, dnum);
        }

        public static Fraction operator -(Fraction numerator1, Fraction numerator2)
        {
            long num = (numerator1.Numerator * numerator2.Denominator) - (numerator2.Numerator * numerator1.Denominator);
            long dnum = numerator1.Denominator * numerator2.Denominator;
            return new Fraction(num, dnum);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.result);
        }
    }
}
