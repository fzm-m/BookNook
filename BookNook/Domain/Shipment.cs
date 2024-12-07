namespace BookNook.Domain
{
    public class Shipment : BaseDomainModel
    {
        public DateTime ShipmentDate { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Status { get; set; }
        public int OrderId { get; set; }

    }
}
