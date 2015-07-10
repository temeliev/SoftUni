namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public abstract class Article : IArticle
    {
        private string make;

        private string model;

        private decimal price;

        protected Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Make is required.");
                }

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Model is required.");
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Price must be positive.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("= {0} {1} =", this.Make, this.Model));
            sb.AppendLine(string.Format("Price: ${0:f2}", this.Price));
            return sb.ToString();
        }
    }
}
