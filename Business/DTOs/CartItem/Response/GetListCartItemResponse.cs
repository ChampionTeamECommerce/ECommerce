namespace Business.DTOs.CartItem.Response
{
    public class GetListCartItemResponse
    {
        public Guid Id { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
