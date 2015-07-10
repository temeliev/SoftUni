namespace NightlifeEntertainment.Venues
{
    using System.Collections.Generic;

    public class ConcertHall : Venue
    {
        private static readonly IList<PerformanceType> Performers = new List<PerformanceType>()
        {
            PerformanceType.Opera,
            PerformanceType.Theatre,
            PerformanceType.Concert
        };

        public ConcertHall(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, Performers)
        {
        }
    }
}
