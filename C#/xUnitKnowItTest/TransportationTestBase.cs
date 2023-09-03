public class TransportationTestBase
{
    protected readonly Tram tram;
    protected readonly Train train;
    protected readonly Bus bus;
    protected readonly Boat boat;
    protected readonly Passenger passenger;

    public TransportationTestBase()
    {
        tram = new Tram();
        train = new Train();
        bus = new Bus();
        boat = new Boat();
        passenger = new Passenger();
    }
}
