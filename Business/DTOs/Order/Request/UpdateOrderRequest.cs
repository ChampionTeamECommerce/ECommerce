namespace Business.DTOs.Order.Request
{
    public class UpdateOrderRequest
    {
        public Guid Id { get; set; }


        public Guid UserId { get; set; }

        public string Name { get; set; }
    }

}
