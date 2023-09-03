import java.util.Map;
import java.util.HashMap;
import java.time.DayOfWeek;

public class Boat extends Transportation {
    public Boat() {
        super(new HashMap<DayOfWeek, Integer>() {{
            put(DayOfWeek.MONDAY, 40);
            put(DayOfWeek.TUESDAY, 40);
            put(DayOfWeek.WEDNESDAY, 0);
            put(DayOfWeek.THURSDAY, 40);
            put(DayOfWeek.FRIDAY, 40);
            put(DayOfWeek.SATURDAY, 0);
            put(DayOfWeek.SUNDAY, 0);
        }});
    }
}