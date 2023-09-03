public class Bus : Transportation
{
    public Bus() : base(new Dictionary<DayOfWeek, int>
    {
        { DayOfWeek.Monday, 30 },
        { DayOfWeek.Tuesday, 30 },
        { DayOfWeek.Wednesday, 30 },
        { DayOfWeek.Thursday, 30 },
        { DayOfWeek.Friday, 30 },
        { DayOfWeek.Saturday, 30 },
        { DayOfWeek.Sunday, 30 }
    })
    {
        // Constructor body 
    }
}