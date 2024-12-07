namespace BookNook.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDate { get; set; }
        public string? PaymentStatus { get; set; }
        public string? ShipmentStatus { get; set; }
        public int UserId { get; set; }
        public int PaymentId { get; set; }
        public int ShipmentId { get; set; }
    }
}
