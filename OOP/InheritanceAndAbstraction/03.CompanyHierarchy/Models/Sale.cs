using System;

namespace _03.CompanyHierarchy
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime productDate;
        private decimal productPrice;

        public Sale(string productName, DateTime productDate, decimal productPrice)
        {
            this.ProductName = productName;
            this.ProductDate = productDate;
            this.ProductPrice = productPrice;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Product name is missing!");
                }

                this.productName = value;
            }
        }

        public DateTime ProductDate
        {
            get { return this.productDate; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Product date is missing!");
                }

                this.productDate = value;
            }
        }

        public decimal ProductPrice
        {
            get { return this.productPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Product price is negative!");
                }

                this.productPrice = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product: {0}\nDate: {1}\nPrice: {2:f2}\n", this.ProductName, this.ProductDate,
                this.ProductPrice);
        }
    }
}
