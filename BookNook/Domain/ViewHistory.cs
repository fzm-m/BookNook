namespace BookNook.Domain
{
    public class ViewHistory : BaseDomainModel
    {
        public DateTime ViewDate { get; set; }

        public int UserId { get; set; }
        public int ItemId { get; set; }

    }
}
