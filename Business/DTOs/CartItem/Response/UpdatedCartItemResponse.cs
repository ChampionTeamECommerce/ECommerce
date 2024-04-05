namespace Business.DTOs.CartItem.Response
{
    public class UpdatedCartItemResponse
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
