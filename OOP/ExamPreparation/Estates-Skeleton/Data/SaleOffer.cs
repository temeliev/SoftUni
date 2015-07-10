namespace Estates.Data
{
    using System.Text;

    using Estates.Interfaces;

    public class SaleOffer : Offer, ISaleOffer
    {
        public SaleOffer() : base(OfferType.Sale) { }

        public SaleOffer(IEstate estate, decimal price)
            : base(estate, OfferType.Sale)
        {
            this.Price = price;
        }

        public decimal Price { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Sale: " + base.ToString());
            sb.AppendFormat(", Price = {0}", this.Price);

            return sb.ToString();
        }
    }
}
