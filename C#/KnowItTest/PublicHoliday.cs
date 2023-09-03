public class PublicHoliday
{
    public List<DateTime> Holidays { get; }
    public PublicHoliday()
    {
        Holidays = new List<DateTime> //A few public holiday from Europe & Middle East, more can be added if needed.
        {
            new DateTime(2023, 1, 1),   // New Year's Day
            new DateTime(2023, 3, 8),   // International Women's Day 
            new DateTime(2023, 4, 14),  // Good Friday
            new DateTime(2023, 4, 17),  // Easter Monday
            new DateTime(2023, 5, 1),   // Labor Day
            new DateTime(2023, 5, 1),   // Labour Day 
            new DateTime(2023, 5, 8),   // Victory in Europe Day 
            new DateTime(2023, 5, 25),  // Ascension Day
            new DateTime(2023, 6, 6),   // National Day (Sweden)
            new DateTime(2023, 6, 15),  // Feast of Corpus Christi 
            new DateTime(2023, 6, 24),  // Midsummer's Day 
            new DateTime(2023, 8, 15),  // Assumption of Mary 
            new DateTime(2023, 10, 3),  // German Unity Day 
            new DateTime(2023, 10, 12), // Spanish National Day 
            new DateTime(2023, 11, 1),  // All Saints' Day 
            new DateTime(2023, 11, 11), // Armistice Day (France and Belgium)
            new DateTime(2023, 12, 8),  // Feast of the Immaculate Conception 
            new DateTime(2023, 12, 25), // Christmas Day 
            new DateTime(2023, 12, 26), // St. Stephen's Day 
        };
    }
}