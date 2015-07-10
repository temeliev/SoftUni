namespace _02.Custom
{
    using System;

    public class Payment
    {
        private string productName;

        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Product name is missing!");
                }

                this.productName = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price cannot be negative!");
                }

                this.price = value;
            }
        }
    }
}
