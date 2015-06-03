using System;
using System.Linq;

namespace _03.PCCatalog
{
    public class Component
    {
        public Component(string name, decimal price, string details)
        {
            this.Name = name;
            this.Price = price;
            this.Details = details;
        }

        public Component(string name, decimal price)
            : this(name, price, null)
        {
        }

        public string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentNullException("Missing name!");
                }
            }
        }

        public decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Negative price!");
                }
            }
        }

        public string details;
        public string Details
        {
            get { return details; }
            set
            {
                if (HasWhiteSpaces(value))
                {
                    throw new ArgumentNullException("Missing details!");
                }

                details = value;
            }
        }

        private static bool HasWhiteSpaces(string value)
        {
            if (value != null)
            {
                if (value.Count(x => x == ' ') == value.Length)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
