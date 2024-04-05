using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.CartItem.Request
{
    public class CreateCartItemRequest
    {
        public Guid? ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
