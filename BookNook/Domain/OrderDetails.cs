namespace BookNook.Domain
{
    public class OrderDetails : BaseDomainModel
    {
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
    }
}
