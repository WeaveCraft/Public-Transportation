public static class TransportationDay {
        public Map<TransportType, Ticket> tickets = new HashMap<>();

        public TransportationDay(Map<TransportType, Ticket> tickets) {
            this.tickets = tickets;
        }
    }