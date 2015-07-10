namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public class ElectricGuitar : Guitar, IElectricGuitar
    {
        private int numberOfAdapters;

        private int numberOfFrets;

        public ElectricGuitar(
            string make,
            string model,
            decimal price,
            string color,
            string bodyWood,
            string fingerboardWood,
            int numberOfAdapters,
            int numberOfFrets)
            : base(make, model, price, color, true, bodyWood, fingerboardWood)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }

        public int NumberOfAdapters
        {
            get
            {
                return this.numberOfAdapters;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of adapters must be positive.");
                }

                this.numberOfAdapters = value;
            }
        }

        public int NumberOfFrets
        {
            get
            {
                return this.numberOfFrets;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of frets must be positive.");
                }

                this.numberOfFrets = value;
            }
        }

        public override string ToString()
        {
            var guitar = new StringBuilder();
            guitar.Append(base.ToString())
                .AppendFormat("Adapters: {0}", this.NumberOfAdapters)
                .AppendLine()
                .AppendFormat("Frets: {0}", this.NumberOfFrets)
                .AppendLine();

            return guitar.ToString();
        }
    }
}
