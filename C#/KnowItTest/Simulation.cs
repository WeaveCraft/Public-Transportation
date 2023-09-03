public class Simulation //This class is to simulate a trip. All methods are called in the Program.cs file.
{
    private Tram tram;
    private Bus bus;
    private Boat boat;
    private Train train;
    private Passenger passenger;
    private PublicHoliday publicHoliday;
    private DateTime tomorrow;
    private DateTime today;

    public Simulation()
    {
        tram = new Tram();
        bus = new Bus();
        boat = new Boat();
        train = new Train();
        passenger = new Passenger();
        publicHoliday = new PublicHoliday();
        tomorrow = DateTime.Today.AddDays(1);
        today = DateTime.Today;
    }
    public void Run()
    {
        passenger.CheckIn(tram, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(bus, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);


        Console.WriteLine($"Total Bill for the day: {passenger.TotalBill} SEK");
    }
    public void Some_Days_Transportation_Is_Free()
    {
        DateTime tramSaturdayFree = new DateTime(2023, 09, 02); //Simulate a weekend when Trams are free.

        passenger.CheckIn(tram, tramSaturdayFree);
        passenger.CheckOut(tramSaturdayFree, publicHoliday);

        Console.WriteLine($"Total Bill for the day: {passenger.TotalBill} SEK");
    }
    public void If_Fare_Overlaps_Two_Days()
    {
        DateTime tramSundayFree = new DateTime(2023, 09, 03); //This is a sunday which is free
        DateTime tramMondayCost = new DateTime(2023, 09, 04); //This is a monday where price is 25 SEK

        passenger.CheckIn(tram, tramSundayFree);
        passenger.CheckOut(tramMondayCost, publicHoliday);

        Console.WriteLine($"Total Bill for the day: {passenger.TotalBill} SEK");
    }
    public void A_Variety_Of_Transports()
    {
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(tomorrow, publicHoliday); 

        Console.WriteLine($"Total Bill for the day: {passenger.TotalBill} SEK");
    }
    public void Public_Holidays_Free()
    {
        DateTime testPublicHoliday = new DateTime(2023, 01, 01); //Known holiday - aka new years day

        passenger.CheckIn(tram, testPublicHoliday);
        passenger.CheckOut(testPublicHoliday, publicHoliday);
    }
    public void If_Passenger_Reaches_200_Rest_Of_Day_Is_Free()
    {
        passenger.CheckIn(tram, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(bus, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);
        passenger.CheckIn(tram, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(bus, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);
        passenger.CheckIn(boat, today);
        passenger.CheckOut(tomorrow, publicHoliday);
        passenger.CheckIn(train, today);
        passenger.CheckOut(today, publicHoliday);

        Console.WriteLine($"Total Bill for the day: {passenger.TotalBill} SEK");
    }
}