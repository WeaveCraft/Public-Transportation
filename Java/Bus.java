import java.util.Map;
import java.util.HashMap;
import java.time.DayOfWeek;

public class Bus extends Transportation {
    public Bus() {
        super(new HashMap<DayOfWeek, Integer>() {{
            put(DayOfWeek.MONDAY, 30);
            put(DayOfWeek.TUESDAY, 30);
            put(DayOfWeek.WEDNESDAY, 30);
            put(DayOfWeek.THURSDAY, 30);
            put(DayOfWeek.FRIDAY, 30);
            put(DayOfWeek.SATURDAY, 30);
            put(DayOfWeek.SUNDAY, 30);
        }});
    }
}