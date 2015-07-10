namespace Estates.Data
{
    using System.Text;

    using Estates.Interfaces;

    public class Office : BuildingEstate, IOffice
    {
        public Office() : base(EstateType.Office) { }

        public Office(string name, double area, string location, bool isFurnished, int numberOfRooms, bool hasElevator)
            : base(name, area, location, isFurnished, numberOfRooms, hasElevator, EstateType.Office)
        {
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Office: " + base.ToString());

            return sb.ToString();
        }
    }
}
