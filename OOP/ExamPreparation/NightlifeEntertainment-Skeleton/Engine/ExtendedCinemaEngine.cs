namespace NightlifeEntertainment.Engine
{
    using System;
    using System.Linq;
    using System.Text;

    using NightlifeEntertainment.Performers;
    using NightlifeEntertainment.Tickets;
    using NightlifeEntertainment.Venues;

    public class ExtendedCinemaEngine : CinemaEngine
    {
        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "opera":
                    var opera = new OperaHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sport = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sport);
                    break;
                case "concert_hall":
                    var concert = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concert);
                    break;
                default:
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "concert":
                    var concertStr = this.GetVenue(commandWords[5]);
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), concertStr, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                case "theatre":
                    var teathreStr = this.GetVenue(commandWords[5]);
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), teathreStr, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                default:
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            string performance = commandWords[1];

            var perf = this.Performances.FirstOrDefault(x => x.Name == performance);
            if (perf == null)
            {
                throw new ArgumentException();
            }

            this.Output.AppendLine(
                string.Format(
                    "{0}: {1} ticket{2}, total: ${3:f2}",
                    perf.Name,
                    perf.Tickets.Count(x => x.Status == TicketStatus.Sold),
                    perf.Tickets.Count == 1 ? "" : "(s)",
                    perf.Tickets.Where(x => x.Status == TicketStatus.Sold).Sum(x => x.Price)));

            this.Output.AppendLine(string.Format("Venue: {0} ({1})", perf.Venue.Name, perf.Venue.Location));

            this.Output.AppendLine(string.Format("Start time: {0}", perf.StartTime));
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            DateTime startTime = DateTime.Parse(commandWords[2] + " " + commandWords[3]);
            string searchWord = commandWords[1];
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"Search for ""{0}""", searchWord).AppendLine();
            sb.AppendLine("Performances:");
            var perf = this.Performances.Where(x => x.Name.ToLower().Contains(searchWord.ToLower()) && x.StartTime >= startTime).OrderBy(x => x.StartTime).ThenByDescending(x => x.BasePrice).ThenBy(x => x.Name);
            if (perf.Any())
            {
                foreach (var p in perf)
                {
                    sb.AppendFormat("-{0}", p.Name).AppendLine();
                }
            }
            else
            {
                sb.AppendLine("no results");
            }

            sb.AppendLine("Venues:");
            var venues = this.Venues.Where(x => x.Name.ToLower().Contains(searchWord.ToLower())).OrderBy(x => x.Name);
            if (venues.Any())
            {
                foreach (var venue in venues)
                {
                    sb.AppendFormat("-{0}", venue.Name).AppendLine();
                    foreach (var p in this.Performances.Where(x => x.Venue.Name == venue.Name && x.StartTime >= startTime).OrderBy(x => x.StartTime))
                    {
                        sb.AppendFormat("--{0}", p.Name).AppendLine();
                    }
                }
            }
            else
            {
                sb.AppendLine("no results");
            }

            this.Output.Append(sb);
        }
    }
}
