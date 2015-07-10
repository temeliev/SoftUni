namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint millimeters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = millimeters;
            this.Usage = usage;
        }

        public uint Milliliters { get; private set; }

        public UsageType Usage { get; private set; }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
        }

        public override string ToString()
        {
            StringBuilder shampoo = new StringBuilder(base.Print());
            shampoo.AppendFormat("  * Quantity: {0} ml", this.Milliliters)
                .AppendLine()
                .AppendFormat("  * Usage: {0}", this.Usage);

            return shampoo.ToString();
        }
    }
}
