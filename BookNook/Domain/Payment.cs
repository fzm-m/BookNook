namespace BookNook.Domain
{
    public class Payment : BaseDomainModel
    {
        public DateTime PaymentDate { get; set; }
        public string? PaymentMethod { get; set; }
        public float PaymentAmount { get; set; }    
        public int OrderId { get; set; }

    }
}
