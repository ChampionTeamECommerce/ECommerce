namespace Business.DTOs.CartItem.Request
{
    public class UpdateCartItemRequest
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
