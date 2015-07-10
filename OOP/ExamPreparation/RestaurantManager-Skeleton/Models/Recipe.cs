namespace RestaurantManager.Models
{
    using System;
    using System.Text;

    using RestaurantManager.Interfaces;

    public abstract class Recipe : IRecipe
    {
        private string name;

        private decimal price;

        private int calories;

        private int quantityPerServing;

        private int timeToPrepare;

        protected Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name is required.");
                }

                this.name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price must be positive.");
                }

                this.price = value;
            }
        }

        public virtual int Calories
        {
            get
            {
                return this.calories;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The calories must be positive.");
                }

                this.calories = value;
            }
        }

        public int QuantityPerServing
        {
            get
            {
                return this.quantityPerServing;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The quantityPerServing must be positive.");
                }

                this.quantityPerServing = value;
            }
        }

        public MetricUnit Unit { get; protected set; }


        public virtual int TimeToPrepare
        {
            get
            {
                return this.timeToPrepare;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The timeToPrepare must be positive.");
                }

                this.timeToPrepare = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("==  {0} == ${1:f2}", this.Name, this.Price).AppendLine()
                .AppendFormat("Per serving: {0} {1}, {2} kcal", this.QuantityPerServing, this.Unit == MetricUnit.Grams ? "g" : "ml", this.Calories)
                             .AppendLine()
                             .AppendFormat("Ready in {0} minutes", this.TimeToPrepare)
                             .AppendLine();

            return sb.ToString();
        }
    }
}
