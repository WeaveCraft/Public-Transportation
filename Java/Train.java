import java.util.Map;
import java.util.HashMap;
import java.time.DayOfWeek;

public class Train extends Transportation {
    public Train() {
        super(new HashMap<DayOfWeek, Integer>() {{
            put(DayOfWeek.MONDAY, 50);
            put(DayOfWeek.TUESDAY, 50);
            put(DayOfWeek.WEDNESDAY, 50);
            put(DayOfWeek.THURSDAY, 50);
            put(DayOfWeek.FRIDAY, 50);
            put(DayOfWeek.SATURDAY, 35);
            put(DayOfWeek.SUNDAY, 35);
        }});
    }
}