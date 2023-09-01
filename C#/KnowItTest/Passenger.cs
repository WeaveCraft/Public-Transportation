class Passenger
{
    public double TotalBill { get; private set; }
    private List<Transportation> trips = new List<Transportation>();
    private List<DateTime> tripDates = new List<DateTime>();

    public void CheckIn(Transportation transportation, DateTime date)
    {
        trips.Add(transportation);
        tripDates.Add(date);
    }

    public void CheckOut(Transportation transportation, DateTime date, PublicHoliday publicHoliday)
    {
        if (trips.Contains(transportation))
        {
            int index = trips.IndexOf(transportation);
            DateTime tripStartDate = tripDates[index];
            DateTime tripEndDate = date;

            int tripDuration = (int)(tripEndDate - tripStartDate).TotalDays;
            int highestPrice = 0;

            if (publicHoliday.Holidays.Contains(tripEndDate.Date))
            {
                highestPrice = 0;
            }
            else
            {
                for (int i = 0; i <= tripDuration; i++)
                {
                    DateTime currentDay = tripStartDate.AddDays(i);
                    int dayPrice = transportation.Prices[currentDay.DayOfWeek];
                    if (dayPrice > highestPrice)
                    {
                        highestPrice = dayPrice;
                    }
                }
            }

            TotalBill += highestPrice;

            if (TotalBill > 200)
            {
                TotalBill = 200;
            }

            trips.RemoveAt(index);
            tripDates.RemoveAt(index);
        }
    }
}