using Transportation.Billing.Enums;

namespace Transportation.Billing
{
    public class TransportationOptions
    {
        public Dictionary<DayOfWeek, TransportationDay> WeeklyTickets { get; }

        public TransportationOptions()
        {
            WeeklyTickets = new Dictionary<DayOfWeek, TransportationDay>
            {
                { DayOfWeek.Monday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(25, false) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(40, false) },
                        { TransportType.Train, new Ticket(50, false) }
                    })
                },
                { DayOfWeek.Tuesday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(25, false) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(40, false) },
                        { TransportType.Train, new Ticket(50, false) }
                    })
                },
                { DayOfWeek.Wednesday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(25, false) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(0, true) },
                        { TransportType.Train, new Ticket(50, false) }
                    })
                },
                { DayOfWeek.Thursday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(25, false) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(40, false) },
                        { TransportType.Train, new Ticket(50, false) }
                    })
                },
                { DayOfWeek.Friday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(25, false) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(40, false) },
                        { TransportType.Train, new Ticket(50, false) }
                    })
                },
                { DayOfWeek.Saturday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(0, true) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(0, true) },
                        { TransportType.Train, new Ticket(35, false) }
                    })
                },
                { DayOfWeek.Sunday, new TransportationDay(new Dictionary<TransportType, Ticket>
                    {
                        { TransportType.Tram, new Ticket(0, true) },
                        { TransportType.Bus, new Ticket(30, false) },
                        { TransportType.Boat, new Ticket(0, true) },
                        { TransportType.Train, new Ticket(35, false) }
                    })
                }
            };
        }
    }
}
