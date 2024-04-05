using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class District : Entity<Guid>
    {
        public string Name { get; set; }
      
        public Guid CityId { get; set; }

     
        public virtual City City { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<Neighborhood> Neighborhoods { get; set; }
    }
}
