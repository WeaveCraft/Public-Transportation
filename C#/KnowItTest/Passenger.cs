public class Passenger
{
    public double TotalBill { get; private set; }
    private Transportation? currentTransportation;
    private List<DateTime> tripDates = new List<DateTime>();

    public void CheckIn(Transportation transportation, DateTime date)
    {
        currentTransportation = transportation;
        tripDates.Add(date);
    }

    public void CheckOut(DateTime date, PublicHoliday publicHoliday)
    {
        if (currentTransportation != null)
        {
            DateTime tripStartDate = tripDates.LastOrDefault();
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
                    int dayPrice = currentTransportation.Prices[currentDay.DayOfWeek];
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

            // Reset the current transportation
            currentTransportation = null;
        }
        else
        {
            Console.WriteLine("Checkout must be paired with a previous Checkin.");
        }
    }
}
