using Core.Entity;

namespace Entities.Concretes;

public class Order : Entity<Guid>
{
    public Guid CustomerId { get; set; }
    public string TrackingNumber { get; set; }

    public ICollection<OrderDetail> OrderDetails { get; set; }
}