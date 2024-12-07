namespace BookNook.Domain
{
    public class Review : BaseDomainModel
    {
        public DateTime ReviewDate { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }

    }
}
