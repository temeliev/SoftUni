namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public abstract class Instrument : Article, IInstrument
    {
        private string color;

        protected Instrument(string make, string model, decimal price, string color, bool isElectronic)
            : base(make, model, price)
        {
            this.Color = color;
            this.IsElectronic = isElectronic;
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The Color is required.");
                }

                this.color = value;
            }
        }

        public bool IsElectronic { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine(string.Format("Color: {0}", this.Color));
            sb.AppendLine(string.Format("Electronic: {0}", this.IsElectronic ? "yes" : "no"));
            return sb.ToString();
        }
    }
}
