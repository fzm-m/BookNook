namespace BookNook.Domain
{
    public class Membership : BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
        public string? Status { get; set; }
        public int UserId { get; set; }
        public int MembershipLevelId { get; set; }

    }
}
