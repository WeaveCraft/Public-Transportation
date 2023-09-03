import java.time.DayOfWeek;
import java.time.LocalDate;
import java.util.*;

public class Passenger {
    private double totalBill;
    private Transportation currentTransportation;
    private List<LocalDate> tripDates = new ArrayList<>();

    public void checkIn(Transportation transportation, LocalDate date) {
        currentTransportation = transportation;
        tripDates.add(date);
    }

    public void checkOut(LocalDate date, PublicHoliday publicHoliday) {
        if (currentTransportation != null) {
            LocalDate tripStartDate = tripDates.get(tripDates.size() - 1);
            LocalDate tripEndDate = date;

            int tripDuration = (int) tripStartDate.until(tripEndDate).getDays();
            int highestPrice = 0;

            if (publicHoliday.getHolidays().contains(tripEndDate)) {
                highestPrice = 0;
            } else {
                for (int i = 0; i <= tripDuration; i++) {
                    LocalDate currentDay = tripStartDate.plusDays(i);
                    int dayPrice = currentTransportation.getPrices().get(currentDay.getDayOfWeek());
                    if (dayPrice > highestPrice) {
                        highestPrice = dayPrice;
                    }
                }
            }

            totalBill += highestPrice;

            if (totalBill > 200) {
                totalBill = 200;
            }

            // Reset the current transportation
            currentTransportation = null;
        } else {
            System.out.println("Checkout must be paired with a previous Checkin.");
        }
    }

    public double getTotalBill() {
        return totalBill;
    }
}