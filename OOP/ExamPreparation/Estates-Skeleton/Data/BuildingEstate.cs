namespace Estates.Data
{
    using System;
    using System.Text;

    using Estates.Interfaces;

    public abstract class BuildingEstate : Estate, IBuildingEstate
    {
        private int rooms;

        protected BuildingEstate(EstateType type) : base(type) { }

        protected BuildingEstate(string name, double area, string location, bool isFurnished, int numberOfRooms, bool hasElevator, EstateType type)
            : base(name, area, location, isFurnished, type)
        {
            this.Rooms = numberOfRooms;
            this.HasElevator = hasElevator;
        }

        public int Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("Rooms has to be in range 0-20");
                }

                this.rooms = value;
            }
        }

        public bool HasElevator { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat(
                ", Rooms: {0}, Elevator: {1}",
                this.Rooms,
                this.HasElevator ? "Yes" : "No");

            return sb.ToString();
        }
    }
}
