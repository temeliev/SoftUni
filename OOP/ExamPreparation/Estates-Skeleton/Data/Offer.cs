namespace Estates.Data
{
    using System.Text;

    using Estates.Interfaces;

    public class Offer : IOffer
    {
        public Offer(OfferType type)
        {
            this.Type = type;
        }

        public Offer(IEstate estate, OfferType type)
        {
            this.Estate = estate;
            this.Type = type;
        }

        public OfferType Type { get; set; }

        public IEstate Estate { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Estate = {0}, Location = {1}", this.Estate.Name, this.Estate.Location);

            return sb.ToString();
        }
    }
}
