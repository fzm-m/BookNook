namespace BookNook.Domain
{
    public class Wishlist : BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }

    }
}
