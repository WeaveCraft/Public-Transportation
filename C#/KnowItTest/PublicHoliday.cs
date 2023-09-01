class PublicHoliday
{
    public List<DateTime> Holidays { get; }

    public PublicHoliday()
    {
        Holidays = new List<DateTime>
        {
            new DateTime(2023, 1, 1),   // New Year's Day
            new DateTime(2023, 4, 14),  // Good Friday
            new DateTime(2023, 4, 17),  // Easter Monday
            new DateTime(2023, 5, 1),   // Labor Day
            new DateTime(2023, 5, 25),  // Ascension Day
            new DateTime(2023, 6, 6),   // National Day (Sweden's National Day)
            new DateTime(2023, 6, 24),  // Midsummer's Day (Sweden)
            new DateTime(2023, 12, 25), // Christmas Day
            new DateTime(2023, 12, 26)  // Boxing Day
        };
    }
}