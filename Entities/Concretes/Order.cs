using Core.Entity;

namespace Entities.Concretes;

public class Order : Entity<Guid>
{
    public Guid UserId { get; set; }
    public string TrackingNumber { get; set; }


    public User User { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; }
}