﻿namespace Business.DTOs.CartItem.Response
{
    public class DeletedCartItemResponse
    {
        public Guid Id { get; set; }
        public Guid? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
