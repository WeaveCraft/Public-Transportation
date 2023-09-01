class Transportation
{
    public Dictionary<DayOfWeek, int> Prices { get; set; }

    public Transportation(Dictionary<DayOfWeek, int> prices)
    {
        Prices = prices;
    }
}
