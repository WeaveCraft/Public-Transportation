using Transportation.Billing.Enums;

namespace Transportation.Billing
{
    public class TransportationDay
    {
        public Dictionary<TransportType, Ticket> Tickets { get; } = new Dictionary<TransportType, Ticket>();

        public TransportationDay(Dictionary<TransportType, Ticket> tickets)
        {
            Tickets = tickets;
        }
    }
}
