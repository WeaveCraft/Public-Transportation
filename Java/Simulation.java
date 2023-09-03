import java.time.DayOfWeek;
import java.time.LocalDate;
import java.util.*;

public class Simulation {
    private Tram tram;
    private Bus bus;
    private Boat boat;
    private Train train;
    private Passenger passenger;
    private PublicHoliday publicHoliday;
    private LocalDate tomorrow;
    private LocalDate today;

    public Simulation() {
        tram = new Tram();
        bus = new Bus();
        boat = new Boat();
        train = new Train();
        passenger = new Passenger();
        publicHoliday = new PublicHoliday();
        tomorrow = LocalDate.now().plusDays(1);
        today = LocalDate.now();
    }

    public void run() {
        passenger.checkIn(tram, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(bus, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);

        System.out.println("Total Bill for the day: " + passenger.getTotalBill() + " SEK");
    }

    public void someDaysTransportationIsFree() {
        LocalDate tramSaturdayFree = LocalDate.of(2023, 9, 2); // Simulate a weekend when Trams are free.

        passenger.checkIn(tram, tramSaturdayFree);
        passenger.checkOut(tramSaturdayFree, publicHoliday);

        System.out.println("Total Bill for the day: " + passenger.getTotalBill() + " SEK");
    }

    public void ifFareOverlapsTwoDays() {
        LocalDate tramSundayFree = LocalDate.of(2023, 9, 3); // This is a Sunday which is free
        LocalDate tramMondayCost = LocalDate.of(2023, 9, 4); // This is a Monday where the price is 25 SEK

        passenger.checkIn(tram, tramSundayFree);
        passenger.checkOut(tramMondayCost, publicHoliday);

        System.out.println("Total Bill for the day: " + passenger.getTotalBill() + " SEK");
    }

    public void aVarietyOfTransports() {
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(tomorrow, publicHoliday);

        System.out.println("Total Bill for the day: " + passenger.getTotalBill() + " SEK");
    }

    public void publicHolidaysFree() {
        LocalDate testPublicHoliday = LocalDate.of(2023, 1, 1); // Known holiday - aka New Year's Day

        passenger.checkIn(tram, testPublicHoliday);
        passenger.checkOut(testPublicHoliday, publicHoliday);
    }

    public void ifPassengerReaches200RestOfDayIsFree() {
        passenger.checkIn(tram, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(bus, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);
        passenger.checkIn(tram, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(bus, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);
        passenger.checkIn(boat, today);
        passenger.checkOut(tomorrow, publicHoliday);
        passenger.checkIn(train, today);
        passenger.checkOut(today, publicHoliday);

        System.out.println("Total Bill for the day: " + passenger.getTotalBill() + " SEK");
    }
}