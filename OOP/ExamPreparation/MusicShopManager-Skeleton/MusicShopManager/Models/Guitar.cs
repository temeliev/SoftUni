﻿namespace MusicShop.Models
{
    using System;
    using System.Text;

    using MusicShopManager.Interfaces;

    public abstract class Guitar : Instrument, IGuitar
    {
        private const int DefaultNumberOsStrings = 6;

        private string bodyWood;

        private string fingerboardWood;

        protected Guitar(
            string make,
            string model,
            decimal price,
            string color,
            bool isElectronic,
            string bodyWood,
            string fingerboardWood)
            : base(make, model, price, color, isElectronic)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
        }

        public string BodyWood
        {
            get
            {
                return this.bodyWood;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The body wood is required.");
                }

                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get
            {
                return this.fingerboardWood;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The fingerboard wood is required.");
                }

                this.fingerboardWood = value;
            }
        }

        public virtual int NumberOfStrings
        {
            get { return DefaultNumberOsStrings; }
        }

        public override string ToString()
        {
            var guitar = new StringBuilder();
            guitar
                .Append(base.ToString())
                .AppendFormat("Strings: {0}", this.NumberOfStrings)
                .AppendLine()
                .AppendFormat("Body wood: {0}", this.BodyWood)
                .AppendLine()
                .AppendFormat("Fingerboard wood: {0}", this.FingerboardWood)
                .AppendLine();
            return guitar.ToString();
        }
    }
}
