namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public class Drink : Recipe, IDrink
    {
        private const int DefaultMaxCalories = 100;
        private const int DefaultTimeToPrepare = 20;

        private int calories;

        private int timeToPrepare;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name, price, calories, quantityPerServing, timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
            this.Calories = calories;
        }

        public bool IsCarbonated { get; private set; }

        public override int Calories
        {
            get
            {
                return this.calories;
            }
            protected set
            {
                if (value > DefaultMaxCalories)
                {
                    throw new ArgumentException(string.Format("The calories in a drink must not be greater than {0}", DefaultMaxCalories));
                }

                this.calories = value;
            }
        }

        public override int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
            protected set
            {
                if (value > DefaultTimeToPrepare)
                {
                    throw new ArgumentException(string.Format("The time to prepare a drink must not be greater than {0} minutes.", DefaultTimeToPrepare));
                }

                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat("Carbonated: {0}", this.IsCarbonated ? "yes" : "no");

            return sb.ToString();
        }
    }
}
