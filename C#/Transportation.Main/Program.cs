using Transportation.Billing;
using Transportation.Billing.Enums;

namespace Transportation.Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Public Transportation Billing System!");

            TransportationOptions transportationOptions = new ();

            int totalBill = 0;
            DayOfWeek currentDay = DayOfWeek.Monday;

            string choice;

            do
            {
                Console.WriteLine($"Current day: {currentDay}");
                Console.WriteLine("1. Choose Transportation");
                Console.WriteLine("2. Skip to another day");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the type of transportation (Tram, Bus, Boat, Train): ");
                        string transportInput = Console.ReadLine();

                        if (Enum.TryParse(transportInput, true, out TransportType selectedTransport))
                        {
                            if (transportationOptions.WeeklyTickets[currentDay].Tickets.TryGetValue(selectedTransport, out Ticket selectedTicket))
                            {
                                if (!selectedTicket.IsFree)
                                {
                                    Console.WriteLine($"Price for {selectedTransport}: {selectedTicket.Price} SEK");
                                    totalBill += selectedTicket.Price;

                                    if (totalBill >= 200)
                                    {
                                        Console.WriteLine("You've reached the daily limit. All rides are now free.");
                                        totalBill = 200;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"{selectedTransport} rides are free today.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid transportation type.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid transportation type.");
                        }
                        break;

                    case "2":
                        currentDay = (DayOfWeek)(((int)currentDay + 1) % 7); // Move to the next day
                        totalBill = 0;
                        Console.WriteLine("Skipped to the next day.");
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }

                Console.WriteLine($"Total bill: {totalBill} SEK\n");

            } while (choice != "3");
        }
    }
}
