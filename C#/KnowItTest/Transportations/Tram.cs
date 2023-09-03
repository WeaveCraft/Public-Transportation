public class Tram : Transportation
{
    public Tram() : base(new Dictionary<DayOfWeek, int>
      {
          { DayOfWeek.Monday, 25 },
          { DayOfWeek.Tuesday, 25 },
          { DayOfWeek.Wednesday, 25 },
          { DayOfWeek.Thursday, 25 },
          { DayOfWeek.Friday, 25 },
          { DayOfWeek.Saturday, 0 },
          { DayOfWeek.Sunday, 0 }
      })
    {
        // Constructor body 
    }
}
