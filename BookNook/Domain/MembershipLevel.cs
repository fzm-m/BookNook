namespace BookNook.Domain
{
    public class MembershipLevel : BaseDomainModel
    {
        public int DiscountRate { get; set; }
        public int MembershipId { get; set; }

    }
}
