import java.util.Map;
import java.util.HashMap;
import java.time.DayOfWeek;


public class Transportation {
    private Map<DayOfWeek, Integer> prices;

    public Transportation(Map<DayOfWeek, Integer> prices) {
        this.prices = prices;
    }

    public Map<DayOfWeek, Integer> getPrices() {
        return prices;
    }
}