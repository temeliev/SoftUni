namespace NightlifeEntertainment.Tickets
{
    public class VipTicket : Ticket
    {
        public VipTicket(IPerformance performance)
            : base(performance, TicketType.VIP)
        {
            this.Performance = performance;
            this.Price = this.CalculatePrice();
        }

        protected override decimal CalculatePrice()
        {
            return this.Performance.BasePrice * 1.5M;
        }
    }
}
