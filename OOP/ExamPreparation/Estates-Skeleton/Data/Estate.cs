namespace Estates.Data
{
    using System;
    using System.Text;

    using Estates.Interfaces;

    public class Estate : IEstate
    {
        private string name;

        private double area;

        private string location;

        public Estate(EstateType type)
        {
            this.Type = type;
        }

        public Estate(string name, double area, string location, bool isFurnished, EstateType type)
        {
            this.Name = name;
            this.Area = area;
            this.Location = location;
            this.IsFurnished = isFurnished;
            this.Type = type;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                this.name = value;
            }
        }


        public EstateType Type { get; set; }


        public double Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("Area has to be in range 0-10000");
                }

                this.area = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException();
                }

                this.location = value;
            }
        }

        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(
                "Name = {0}, Area = {1}, Location = {2}, Furnitured = {3}",
                this.Name,
                this.Area,
                this.Location,
                this.IsFurnished ? "Yes" : "No");

            return sb.ToString();
        }
    }
}
