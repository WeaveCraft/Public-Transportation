using Xunit;

public class TransportationTests
{
    private readonly Tram tram;
    private readonly Bus bus;
    private readonly Passenger passenger;

    public TransportationTests()
    {
        tram = new Tram();
        bus = new Bus();
        passenger = new Passenger();
    }

    [Fact]
    public void TramPriceOnWeekday()
    {
        // Arrange: Create the necessary objects for testing
        var today = new DateTime(2023, 9, 4); // A weekday

        // Act: Calculate the cost of tram transportation on a weekday
        passenger.CheckIn(tram, today);
        passenger.CheckOut(today, new PublicHoliday());

        // Assert: Verify that the cost matches the expected price for a weekday
        Assert.Equal(25, passenger.TotalBill);
    }

    [Fact]
    public void BusPriceOnWeekend()
    {
        // Arrange: Create the necessary objects for testing
        var today = new DateTime(2023, 9, 2); // A weekend day

        // Act: Calculate the cost of bus transportation on a weekend
        passenger.CheckIn(bus, today);
        passenger.CheckOut(today, new PublicHoliday());

        // Assert: Verify that the cost matches the expected price for a weekend
        Assert.Equal(30, passenger.TotalBill);
    }

    [Fact]
    public void TramPriceOverlappingWeekdays()
    {
        // Arrange: Create the necessary objects for testing
        var today = new DateTime(2023, 9, 4); // weekend(sunday)
        var tomorrow = today.AddDays(1); 

        // Act: Calculate the cost of tram transportation on overlapping weekdays
        passenger.CheckIn(tram, today);
        passenger.CheckOut(tomorrow, new PublicHoliday());

        // Assert: Verify that the cost matches the expected price for two weekdays
        Assert.Equal(25, passenger.TotalBill);
    }

    [Fact]
    public void BusPriceOverlappingWeekendAndWeekday()
    {
        // Arrange: Create the necessary objects for testing
        var today = new DateTime(2023, 9, 3); // weekend(saturday)
        var tomorrow = today.AddDays(1); // Next day (weekday)

        // Act: Calculate the cost of bus transportation on overlapping weekend and weekday
        passenger.CheckIn(bus, today);
        passenger.CheckOut(tomorrow, new PublicHoliday());

        // Assert: Verify that the cost matches the expected price for a weekend and a weekday
        Assert.Equal(30, passenger.TotalBill);
    }

    [Fact]
    public void CostIsZeroOnPublicHoliday()
    {
        // Arrange: Create the necessary objects for testing
        var today = new DateTime(2023, 1, 1); // A public holiday

        // Act: Calculate the cost of bus transportation on a public holiday
        passenger.CheckIn(bus, today);
        passenger.CheckOut(today, new PublicHoliday());

        // Assert: Verify that the cost is zero on a public holiday
        Assert.Equal(0, passenger.TotalBill);
    }
}
