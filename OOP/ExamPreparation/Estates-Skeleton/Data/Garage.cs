namespace Estates.Data
{
    using System;
    using System.Text;

    using Estates.Interfaces;

    public class Garage : Estate, IGarage
    {
        private int width;

        private int height;

        public Garage() : base(EstateType.Garage) { }

        public Garage(string name, double area, string location, bool isFurnished, int width, int height)
            : base(name, area, location, isFurnished, EstateType.House)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Width has to be in range 0-500");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException("Height has to be in range 0-500");
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Garage: " + base.ToString());
            sb.AppendFormat(", Width: {0}, Height: {1}", this.Width, this.Height);

            return sb.ToString();
        }
    }
}
