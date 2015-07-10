namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private string name;

        private string brand;

        private decimal price;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Gender = gender;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));
                Validator.CheckIfStringLengthIsValid(value, 10, 3, string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", 3, 10));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));
                Validator.CheckIfStringLengthIsValid(value, 10, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", 2, 10));

                this.brand = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The product price cannot be negative!");
                }

                this.price = value;
            }
        }

        public GenderType Gender { get; private set; }

        public string Print()
        {
            StringBuilder product = new StringBuilder();
            product.AppendFormat("- {0} - {1}:", this.Brand, this.Name)
                .AppendLine()
                .AppendFormat("  * Price: ${0}", this.Price)
                .AppendLine()
                .AppendFormat("  * For gender: {0}", this.Gender).AppendLine();

            return product.ToString();
        }
    }
}
