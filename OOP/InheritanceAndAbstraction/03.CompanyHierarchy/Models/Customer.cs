using System;

namespace _03.CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private decimal moneySpent;

        public Customer(int id, string firstName, string lastName, decimal moneySpent)
            : base(id, firstName, lastName)
        {
            this.MoneySpent = moneySpent;
        }

        public decimal MoneySpent
        {
            get { return moneySpent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The spent money are negative!");
                }

                moneySpent = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Spent: {0:f2} lv.", this.MoneySpent);
        }
    }
}
