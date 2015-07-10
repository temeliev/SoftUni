namespace Estates.Data
{
    using System;
    using System.Text;

    using Estates.Interfaces;

    public class House : Estate, IHouse
    {
        private int floors;

        public House() : base(EstateType.House) { }

        public House(string name, double area, string location, bool isFurnished, int floors)
            : base(name, area, location, isFurnished, EstateType.House)
        {
            this.Floors = floors;
        }

        public int Floors
        {
            get
            {
                return this.floors;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Floors have to be in range 0-10");
                }

                this.floors = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("House: " + base.ToString());
            sb.AppendFormat(", Floors: {0}", this.Floors);
                
            return sb.ToString();
        }
    }
}
