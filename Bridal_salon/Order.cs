namespace Bridal_salon
{
    public class Order
    {
        public int OrdNum { get; set; }
        public string BrideId { get; set; }
        public int DressId{ get; set; }
        public DateTime DateOfOrder { get; set; }
        public DateTime TheWeddingTime { get; set; }
        public string DressmakerId { get; set; }
        public double TotalPrice { get; set; }
        public DateTime MeasurementDate { get; set; }
        public string Comments { get; set; }
        public bool AttachTulle { get; set; }
    }
}
