
using Core.Entity;

namespace Entities.Concretes;

public class OrderDetail : Entity<Guid>
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice { get; set; }

    public ICollection<Product> Products { get; set; }
    public Order? Order { get; set; }
} 