namespace BookNook.Domain
{
    public class Promotion : BaseDomainModel
    {
        public string? PromoCode { get; set; }
        public string? Description { get; set; }
        public int DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? ApplicableTo { get; set; }


    }
}
