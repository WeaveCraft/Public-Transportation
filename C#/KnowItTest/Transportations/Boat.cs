public class Boat : Transportation
{
    public Boat() : base(new Dictionary<DayOfWeek, int>
    {
        { DayOfWeek.Monday, 40 },
        { DayOfWeek.Tuesday, 40 },
        { DayOfWeek.Wednesday, 0 },
        { DayOfWeek.Thursday, 40 },
        { DayOfWeek.Friday, 40 },
        { DayOfWeek.Saturday, 0 },
        { DayOfWeek.Sunday, 0 }
    })
    {
        // Constructor body 
    }
}