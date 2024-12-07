namespace BookNook.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name { get; set; } 
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int PhoneNumber { get; set; }
        public string? Role { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
