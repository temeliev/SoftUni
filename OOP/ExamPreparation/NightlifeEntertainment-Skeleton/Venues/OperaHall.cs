namespace NightlifeEntertainment.Venues
{
    using System.Collections.Generic;

    public class OperaHall : Venue
    {
        private static readonly IList<PerformanceType> Performers = new List<PerformanceType>()
        {
            PerformanceType.Opera,
            PerformanceType.Theatre
        };

        public OperaHall(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, Performers)
        {
        }
    }
}
