using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class UserAddresses : Entity<Guid>
    {
        public string Name { get; set; }

        public Guid AddressId { get; set; }
        
        public virtual User User { get; set; }
        public ICollection <Address> Addresses { get; set; }


    }
}
