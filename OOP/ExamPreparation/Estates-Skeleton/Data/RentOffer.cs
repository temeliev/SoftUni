namespace Estates.Data
{
    using System.Text;

    using Estates.Interfaces;

    public class RentOffer : Offer, IRentOffer
    {
        public RentOffer() : base(OfferType.Rent) { }

        public RentOffer(IEstate estate, decimal pricePerMonth)
            : base(estate, OfferType.Rent)
        {
            this.PricePerMonth = pricePerMonth;
        }

        public decimal PricePerMonth { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Rent: " + base.ToString());
            sb.AppendFormat(", Price = {0}", this.PricePerMonth);

            return sb.ToString();
        }
    }
}
