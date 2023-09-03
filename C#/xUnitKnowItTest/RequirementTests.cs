using Xunit;

public class RequirementTests : TransportationTestBase
{
    [Fact]
    public void CalculateTotalBillOver200()
    {
        var testDay = new DateTime(2023, 9, 4); // A weekday

        passenger.CheckIn(tram, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(bus, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(train, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(bus, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(boat, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(bus, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(tram, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());

        Assert.Equal(200, passenger.TotalBill);
    }

    [Fact]
    public void CalculateFreeRideOnWeekend()
    {
        var testDay = new DateTime(2023, 9, 2); // A weekend day

        passenger.CheckIn(tram, testDay);

        passenger.CheckOut(testDay, new PublicHoliday());

        // Since it's a weekend day, the ride is free.
        Assert.Equal(0, passenger.TotalBill);
    }

    [Fact]
    public void CalculateFareOnOverlappingDays()
    {
        var weekend = new DateTime(2023, 9, 3); // A weekend day which is free
        var dayAfter = new DateTime(2023, 9, 4); // Next day (weekday)

        passenger.CheckIn(tram, weekend);
        passenger.CheckOut(dayAfter, new PublicHoliday());

        Assert.Equal(25, passenger.TotalBill);
    }

    [Fact]
    public void CalculateFreeRideOnPublicHoliday()
    {
        var testDay = new DateTime(2023, 1, 1); // New Year's Day (public holiday)

        passenger.CheckIn(tram, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(train, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(bus, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());
        passenger.CheckIn(boat, testDay);
        passenger.CheckOut(testDay, new PublicHoliday());


        // Since it's a public holiday, all trips are free.
        Assert.Equal(0, passenger.TotalBill);
    }

}
