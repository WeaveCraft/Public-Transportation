import java.util.*;

public static void main(String[] args) {
        Map<DayOfWeek, TransportationDay> weeklyTickets = new HashMap<>();
        // Initialize with ticket prices (same as before)

        int totalBill = 0;
        DayOfWeek currentDay = DayOfWeek.Monday;

        System.out.println("Welcome to the Public Transportation Billing System!");

        Scanner scanner = new Scanner(System.in);
        String choice;

        do {
            System.out.println("Current day: " + currentDay);
            System.out.println("1. Choose Transportation");
            System.out.println("2. Skip to another day");
            System.out.println("3. Quit");
            System.out.print("Enter your choice: ");
            choice = scanner.nextLine();

            switch (choice) {
                case "1":
                    System.out.print("Enter the type of transportation (Tram, Bus, Boat, Train): ");
                    String transportInput = scanner.nextLine();

                    TransportType selectedTransport = TransportType.valueOf(transportInput.toUpperCase());

                    if (weeklyTickets.get(currentDay).tickets.containsKey(selectedTransport)) {
                        Ticket selectedTicket = weeklyTickets.get(currentDay).tickets.get(selectedTransport);

                        if (!selectedTicket.isFree) {
                            System.out.println("Price for " + selectedTransport + ": " + selectedTicket.price + " SEK");
                            totalBill += selectedTicket.price;

                            if (totalBill >= 200) {
                                System.out.println("You've reached the daily limit. All rides are now free.");
                                totalBill = 0;
                            }
                        } else {
                            System.out.println(selectedTransport + " rides are free today.");
                        }
                    } else {
                        System.out.println("Invalid transportation type.");
                    }
                    break;

                case "2":
                    currentDay = DayOfWeek.values()[(currentDay.ordinal() + 1) % 7]; // Move to the next day
                    totalBill = 0;
                    System.out.println("Skipped to the next day.");
                    break;

                case "3":
                    System.out.println("Goodbye!");
                    break;

                default:
                    System.out.println("Invalid choice. Please enter 1, 2, or 3.");
                    break;
            }

            System.out.println("Total bill: " + totalBill + " SEK\n");

        } while (!choice.equals("3"));

        scanner.close();
    }