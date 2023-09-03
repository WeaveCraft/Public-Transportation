public class Train : Transportation
{
    public Train() : base(new Dictionary<DayOfWeek, int>
    {
        { DayOfWeek.Monday, 50 },
        { DayOfWeek.Tuesday, 50 },
        { DayOfWeek.Wednesday, 50 },
        { DayOfWeek.Thursday, 50 },
        { DayOfWeek.Friday, 50 },
        { DayOfWeek.Saturday, 35 },
        { DayOfWeek.Sunday, 35 }
    })
    {
        // Constructor body 
    }
}