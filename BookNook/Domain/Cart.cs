namespace BookNook.Domain
{
    public class Cart : BaseDomainModel
    {
        public DateTime DateAdded { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
    }
}
