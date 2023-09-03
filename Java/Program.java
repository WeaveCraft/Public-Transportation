import java.util.Map;
import java.util.HashMap;
import java.time.DayOfWeek;

public class Program {
    public static void main(String[] args) {
        Simulation simulation = new Simulation();

        /*
         * Simulation.java file includes methods to simulate different trips. 
         * Uncomment and run each method individually since running all together will be seen as "one trip" and will result in a price of 200.
         * You can find equivalent tests in a separate test class for each requirement.
        */

        simulation.run();

        // simulation.ifPassengerReaches200RestOfDayIsFree();

        // simulation.someDaysTransportationIsFree();

        //simulation.ifFareOverlapsTwoDays();

        //simulation.aVarietyOfTransports();

        //simulation.publicHolidaysFree();
    }
}