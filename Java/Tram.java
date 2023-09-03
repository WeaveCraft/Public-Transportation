import java.util.Map;
import java.util.HashMap;
import java.time.DayOfWeek;

public class Tram extends Transportation {
    public Tram() {
        super(new HashMap<DayOfWeek, Integer>() {{
            put(DayOfWeek.MONDAY, 25);
            put(DayOfWeek.TUESDAY, 25);
            put(DayOfWeek.WEDNESDAY, 25);
            put(DayOfWeek.THURSDAY, 25);
            put(DayOfWeek.FRIDAY, 25);
            put(DayOfWeek.SATURDAY, 0);
            put(DayOfWeek.SUNDAY, 0);
        }});
    }
}