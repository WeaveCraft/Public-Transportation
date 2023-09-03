public class Program
{
    static void Main()
    {
        var simulation = new Simulation();

        /*
         * Simulation.cs file includes a method to simulate a trip for each requirement. 
         * Comment out and comment in each induvidually since running all together will be seen as "one trip" and will result in a price of 200.
         * In xUnitKnowItTest you can find test for each requirement also.
        */

        simulation.Run();

        //simulation.If_Passenger_Reaches_200_Rest_Of_Day_Is_Free();

        //simulation.Some_Days_Transportation_Is_Free();

        //simulation.If_Fare_Overlaps_Two_Days();

        //simulation.A_Variety_Of_Transports();

        //simulation.Public_Holidays_Free();
    }
}