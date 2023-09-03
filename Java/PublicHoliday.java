import java.time.DayOfWeek;
import java.time.LocalDate;
import java.util.*;

public class PublicHoliday {
    private List<LocalDate> holidays;

    public PublicHoliday() {
        holidays = Arrays.asList(
            LocalDate.of(2023, 1, 1),   // New Year's Day
            LocalDate.of(2023, 3, 8),   // International Women's Day 
            LocalDate.of(2023, 4, 14),  // Good Friday
            LocalDate.of(2023, 4, 17),  // Easter Monday
            LocalDate.of(2023, 5, 1),   // Labor Day
            LocalDate.of(2023, 5, 1),   // Labour Day 
            LocalDate.of(2023, 5, 8),   // Victory in Europe Day 
            LocalDate.of(2023, 5, 25),  // Ascension Day
            LocalDate.of(2023, 6, 6),   // National Day (Sweden)
            LocalDate.of(2023, 6, 15),  // Feast of Corpus Christi 
            LocalDate.of(2023, 6, 24),  // Midsummer's Day 
            LocalDate.of(2023, 8, 15),  // Assumption of Mary 
            LocalDate.of(2023, 10, 3),  // German Unity Day 
            LocalDate.of(2023, 10, 12), // Spanish National Day 
            LocalDate.of(2023, 11, 1),  // All Saints' Day 
            LocalDate.of(2023, 11, 11), // Armistice Day (France and Belgium)
            LocalDate.of(2023, 12, 8),  // Feast of the Immaculate Conception 
            LocalDate.of(2023, 12, 25), // Christmas Day 
            LocalDate.of(2023, 12, 26)  // St. Stephen's Day 
        );
    }

    public List<LocalDate> getHolidays() {
        return holidays;
    }
}