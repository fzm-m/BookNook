namespace BookNook.Domain
{
    public class Item : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
    }
}
