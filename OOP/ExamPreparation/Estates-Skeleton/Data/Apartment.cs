namespace Estates.Data
{
    using System.Text;

    using Estates.Interfaces;

    public class Apartment : BuildingEstate, IApartment
    {
        public Apartment()
            : base(EstateType.Apartment)
        {
        }

        public Apartment(string name, double area, string location, bool isFurnished, int numberOfRooms, bool hasElevator)
            : base(name, area, location, isFurnished, numberOfRooms, hasElevator, EstateType.Apartment)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Apartment: " + base.ToString());

            return sb.ToString();
        }
    }
}
