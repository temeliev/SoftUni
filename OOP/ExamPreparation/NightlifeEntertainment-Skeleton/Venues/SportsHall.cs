namespace NightlifeEntertainment.Venues
{
    using System.Collections.Generic;

    public class SportsHall : Venue
    {
        private static readonly IList<PerformanceType> Performers = new List<PerformanceType>()
        {
            PerformanceType.Sport,
            PerformanceType.Concert
        };

        public SportsHall(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, Performers)
        {
        }
    }
}
