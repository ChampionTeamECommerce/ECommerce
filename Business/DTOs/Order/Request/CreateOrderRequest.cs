using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTOs.Order.Request
{
    public class CreateOrderRequest
    {
        public string TrackingNumber { get; set; }
        public Guid UserId { get; set; }

    }

}
