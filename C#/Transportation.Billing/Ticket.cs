namespace Transportation.Billing
{
    public class Ticket
    {
        public int Price { get; }
        public bool IsFree { get; }

        public Ticket(int price, bool isFree)
        {
            Price = price;
            IsFree = isFree;
        }
    }
}
