namespace NightlifeEntertainment.Tickets
{
    public class StudentTicket : Ticket
    {
        public StudentTicket(IPerformance performance)
            : base(performance, TicketType.Student)
        {
            this.Performance = performance;
            this.Price = this.CalculatePrice();
        }

        protected override decimal CalculatePrice()
        {
            return this.Performance.BasePrice * 0.8M;
        }
    }
}
