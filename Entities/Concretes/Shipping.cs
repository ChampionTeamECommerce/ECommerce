
using Core.Entity;

namespace Entities.Concretes;

public class Shipping:Entity<Guid>
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
  

}	


//orderDetail bağlanabilir sonra