class Program
{
    static void Main()
    {
        var tramPrices = new Dictionary<DayOfWeek, int>
        {
            { DayOfWeek.Monday, 25 },
            { DayOfWeek.Tuesday, 25 },
            { DayOfWeek.Wednesday, 25 },
            { DayOfWeek.Thursday, 25 },
            { DayOfWeek.Friday, 25 },
            { DayOfWeek.Saturday, 0 },
            { DayOfWeek.Sunday, 0 }
        };

        var busPrices = new Dictionary<DayOfWeek, int>
        {
            { DayOfWeek.Monday, 30 },
            { DayOfWeek.Tuesday, 30 },
            { DayOfWeek.Wednesday, 30 },
            { DayOfWeek.Thursday, 30 },
            { DayOfWeek.Friday, 30 },
            { DayOfWeek.Saturday, 30 },
            { DayOfWeek.Sunday, 30 }
        };

        var boatPrices = new Dictionary<DayOfWeek, int>
        {
            { DayOfWeek.Monday, 40 },
            { DayOfWeek.Tuesday, 40 },
            { DayOfWeek.Wednesday, 0 },
            { DayOfWeek.Thursday, 40 },
            { DayOfWeek.Friday, 40 },
            { DayOfWeek.Saturday, 0 },
            { DayOfWeek.Sunday, 0 }
        };

        var trainPrices = new Dictionary<DayOfWeek, int>
        {
            { DayOfWeek.Monday, 50 },
            { DayOfWeek.Tuesday, 50 },
            { DayOfWeek.Wednesday, 50 },
            { DayOfWeek.Thursday, 50 },
            { DayOfWeek.Friday, 50 },
            { DayOfWeek.Saturday, 35 },
            { DayOfWeek.Sunday, 35 }
        };

        var tram = new Transportation(tramPrices);
        var bus = new Transportation(busPrices);
        var boat = new Transportation(boatPrices);
        var train = new Transportation(trainPrices);

        var passenger = new Passenger();
        var publicHoliday = new PublicHoliday();

        DateTime tomorrow = DateTime.Today.AddDays(1);
        DateTime today = DateTime.Today;

        passenger.CheckIn(tram, today);
        passenger.CheckOut(tram, tomorrow, publicHoliday);

        passenger.CheckIn(bus, today);
        passenger.CheckOut(bus, tomorrow, publicHoliday);

        passenger.CheckIn(boat, today);
        passenger.CheckOut(boat, tomorrow, publicHoliday);

        passenger.CheckIn(train, today);
        passenger.CheckOut(train, today, publicHoliday);

        Console.WriteLine($"Total Bill for the day: {passenger.TotalBill} SEK");
    }
}