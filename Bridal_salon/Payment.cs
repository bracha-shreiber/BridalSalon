namespace Bridal_salon
{
    public class Payment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentCount { get; set; }
        public double Price { get; set; }
        public bool Reception { get; set; }
        public string EmailForSendingReception { get; set; }
    }
}
